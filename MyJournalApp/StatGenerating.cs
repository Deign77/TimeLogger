using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLogger
{
    public partial class TimeLogger
    {
        private void GetStats(string input)
        {
            statList = new Stats() { Dates = new List<string>(), Activities = new List<string>(), HoursWorked = new List<double>(), Achievements = new List<string>(), Comments = new List<string>() };
            statEntryList = new List<Entry>();
            int temp;

            if (int.TryParse(input, out temp))
            {
                if (input.Length == 4)
                {
                    for (int i = 0; i < Years[selectedYear].Count(); i++)
                        AddEntryToStats(Years[selectedYear][i]);
                }
                else
                {
                    for (int i = 0; i < Years[selectedYear].Count(); i++)
                    {
                        if (int.Parse(Years[selectedYear][i].Date.Substring(3, 2)) == int.Parse(input))
                            AddEntryToStats(Years[selectedYear][i]);
                    }
                }
            }
            else
            {
                foreach (KeyValuePair<string, List<Entry>> year in Years)
                {
                    for (int i = 0; i < year.Value.Count(); i++)
                    {
                        if (year.Value[i].Activity == input)
                            AddEntryToStats(year.Value[i]);
                    }
                }
            }
        }

        private void DisplayStats()
        {
            ResetStatLabels();
            dgv.Rows.Clear();

            statEntryList = statEntryList.OrderBy(x => x.Date.Substring(6, 4)).ThenBy(x => x.Date.Substring(3, 2)).ThenBy(x => x.Date.Substring(0, 2)).ToList();

            for (int i = 0; i < statEntryList.Count(); i++)
            {
                dgv.Rows.Add();
                PopulateDGVRow(dgv.Rows[i], statEntryList[i]);
                if (i % 2 == 0) dgv.Rows[i].DefaultCellStyle.BackColor = Color.PapayaWhip;
            }

            lblNoData.Visible = false;
            lblDaysWorkedDisplay.Text = statList.Dates.Distinct().Count().ToString();
            lblHoursWorkedDisplay.Text = statList.HoursWorked.Sum().ToString();
            lblAverageHoursDisplay.Text = Math.Round(statList.HoursWorked.Sum() / statList.HoursWorked.Count(), 2).ToString();
            lblTotalActivitiesDisplay.Text = statList.Activities.Distinct().Count().ToString();
            lblOverallBestDayDisplay.Text = statList.HoursWorked.Max().ToString() + "hrs";
            lblMonthsWorkedDisplay.Text = statList.Dates.Select(x => x.Substring(3, 2)).Distinct().Count().ToString();

            string[] statActs = statList.Activities.Distinct().ToArray();

            cmbxMostActive.Items.Clear();

            if (statActs.Count() > 1)
            {
                statActs = statActs.OrderByDescending(x => statList.Activities.Count(e => e == x)).ToArray();

                for (int i = 0; i < statActs.Count(); i++)
                    cmbxMostActive.Items.Add(statActs[i]);
            }
            else
            {
                string[] months = statList.Dates.Select(x => CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(int.Parse(x.Substring(3, 2))) + " " + x.Substring(6, 4)).Distinct().ToArray();
                
                if (months.Count() > 1)
                {
                    for (int i = 0; i < months.Count(); i++)
                        cmbxMostActive.Items.Add(months[i]);
                }
            }
        }

        private void cmbxMostActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string activity = cmbxMostActive.Text;
            if (activity.Length > 0)
            {
                lblStatsForActivity.Text = string.Concat(lblStatsForActivity.Text.TakeWhile(x => x != '-')) + " - " + activity;

                if (monthButtons.Where(x => activity.Substring(0, activity.Length - 5) == x.Text).Count() > 0)
                {
                    int month = DateTime.ParseExact(activity.Substring(0, activity.Length - 5), "MMMM", CultureInfo.CurrentCulture).Month;
                    lblSelectionHoursWorkedDisplay.Text = statList.HoursWorked.Where((x, i) => int.Parse(statList.Dates[i].Substring(3, 2)) == month).Sum().ToString() + "hrs";
                    //lblSelectionBestDayDisplay.Text = statList.HoursWorked.Where((x, i) => int.Parse(statList.Dates[i].Substring(3, 2)) == month).Max().ToString() + "hrs";
                    lblSelectionBestDayDisplay.Text = statList.HoursWorked.Where((x, i) => int.Parse(statList.Dates[i].Substring(3, 2)) == month).OrderBy(x => x).LastOrDefault().ToString() + "hrs";
                    lblSelectionDaysWorkedDisplay.Text = statList.Dates.Where(x => int.Parse(x.Substring(3, 2)) == month).Distinct().Count().ToString();
                }
                else
                {
                    lblSelectionHoursWorkedDisplay.Text = statList.HoursWorked.Where((x, i) => statList.Activities[i] == activity).Sum().ToString();
                    lblSelectionBestDayDisplay.Text = statList.HoursWorked.Where((x, i) => statList.Activities[i] == activity).Max().ToString() + "hrs";
                    lblSelectionDaysWorkedDisplay.Text = statList.Dates.Where((x, i) => statList.Activities[i] == activity).Distinct().Count().ToString();
                }
            } 
        }
    }
}
