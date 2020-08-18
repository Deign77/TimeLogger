using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TimeLogger
{
    public partial class TimeLogger : Form
    {
        public TimeLogger()
        {
            InitializeComponent();
        }

        private void TimeLogger_Load(object sender, EventArgs e)
        {
            Years = new Dictionary<string, List<Entry>>();
            monthButtons = new List<Button> { btnJanuary, btnFebruary, btnMarch, btnApril, btnMay, btnJune, btnJuly, btnAugust, btnSeptember, btnOctober, btnNovember, btnDecember };
            yearButtons = new List<Button> { btnYear1, btnYear2, btnYear3, btnYear4, btnYear5 };

            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;  

            if (File.Exists(path))
            {
                string returnedJSONString = File.ReadAllText(path);
                JArray jArray = JArray.Parse(returnedJSONString);

                for (int i = 0; i < jArray.Count(); i++)
                {
                    Entry loadedEntry = JsonConvert.DeserializeObject<Entry>(jArray[i].ToString());
                    AddEntrytoYear(loadedEntry);
                }
                
                int yearCount = 0;

                foreach (KeyValuePair<string, List<Entry>> kvp in Years)
                {
                    if (yearCount == 5) MessageBox.Show("You have used this app for more than 5 years!", "Congratulations!");
                    else
                    {
                        yearButtons[yearCount].Visible = true;
                        yearButtons[yearCount].Text = kvp.Key;
                        yearCount++;
                    }
                }
                if (yearCount == 0) lblNoData.Visible = true;
                else
                {
                    selectedYear = Years.Keys.First();
                    yearButtons[0].BackColor = Color.Gold;
                }     
            }
        }

        private void TimeLogger_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (savedEntryCount + deletedEntryCount + editedEntryCount > 0)  SaveToFile();
        }

        private void ResetStatLabels()
        {
            lblDaysWorkedDisplay.Text = "-";
            lblSelectionDaysWorkedDisplay.Text = "-";
            lblHoursWorkedDisplay.Text = "-"; 
            lblSelectionHoursWorkedDisplay.Text = "-";
            lblAverageHoursDisplay.Text = "-";
            lblMonthsWorkedDisplay.Text = "-";
            lblTotalActivitiesDisplay.Text = "-";
            lblOverallBestDayDisplay.Text = "-";
            lblSelectionBestDayDisplay.Text = "-";
        }
    }
}
