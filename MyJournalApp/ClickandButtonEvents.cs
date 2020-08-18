using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLogger
{
    public partial class TimeLogger
    {
        private void MonthButtonClick(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = LoadMonthData(((Button)sender).Name.Substring(3)) ? Color.Red : Color.Green;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            PopulateInputFields(new Entry());
        }

        private void btnSearchforProject_Click(object sender, EventArgs e)
        {
            SearchforProject();
        }

        private void btnshowmonths_Click(object sender, EventArgs e)
        {
            CalendarToGrid();
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            if (savedEntryCount + deletedEntryCount + editedEntryCount == 0) MessageBox.Show("You have no unsaved changes.", "Nothing to save");
            else SaveToFile();
        }

        private void btnNewEntrytoStats_Click(object sender, EventArgs e)
        {
            lblStatsFor.Visible = pnlSelectSearch.Visible = lblStatsFor.Visible ? false : true;
            pnlNewEntry.Visible = pnlNewEntry.Visible ? false : true;
            btnNewEntrytoStats.Text = btnNewEntrytoStats.Text == "Entry Panel" ? "Stats" : "Entry Panel";
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            txtbxDate.Text = DateTime.Now.ToString();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (i == e.RowIndex)
                {
                    dgv.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dgv.Rows[i].DefaultCellStyle.Font = new Font("Trebuchet MS", 11);
                }
                else
                {
                    dgv.Rows[i].DefaultCellStyle.Font = new Font("Trebuchet MS", 10);
                    if (i % 2 == 0) dgv.Rows[i].DefaultCellStyle.BackColor = Color.PapayaWhip;
                    else dgv.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void YearButtonClick(object sender, EventArgs e)
        {
            foreach (Button button in yearButtons)
                button.BackColor = Color.DarkGray;

            selectedYear = ((Button)sender).Text;
            ((Button)sender).BackColor = Color.Gold;

            GetStats(selectedYear);
            DisplayStats();

            lblStatsFor.Text = "  Stats for " + selectedYear;
            lblStatsForActivity.Text = selectedYear;
            lblNoData.Visible = false;

            foreach (Button btn in monthButtons)
                btn.ForeColor = Color.Black;
        }


        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            if (EditOrDeleteEntry(selectedRowIndex, "Delete") == DialogResult.Yes)
            {
                Years[selectedYear].RemoveAt(selectedEntryIndex);
                deletedEntryCount++;
                lblDeletedEntries.Text = deletedEntryCount.ToString();
                lblDeletedEntries.Visible = true;
            }
        }

        private void btnEditEntry_Click(object sender, EventArgs e)
        {
            if (EditOrDeleteEntry(selectedRowIndex, "Edit") == DialogResult.Yes)
            {
                Entry loadedEntry = Years[selectedYear][selectedEntryIndex];
                PopulateInputFields(loadedEntry);

                editingEntry = true;
                btnEditEntry.Text = "NOW EDITING";
                btnDeleteEntry.Enabled = false;
                btnEditEntry.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double temp;

            if (txtbxActivity.Text.Length == 0) MessageBox.Show("Activity field is empty", "Incomplete Entry");
            else if (txtbxHours.Text.Length == 0) MessageBox.Show("Hours field is empty", "Incomplete Entry");
            else if (!double.TryParse(txtbxHours.Text, out temp)) MessageBox.Show("Hours field can only accept decimal numbers", "Wrong data type");
            else
            {
                Entry newEntry = new Entry();

                newEntry.Date = txtbxDate.Text;
                newEntry.Hours = double.Parse(txtbxHours.Text);
                newEntry.Activity = txtbxActivity.Text;
                newEntry.Achievements = txtbxAchievements.Text;
                newEntry.Comments = txtbxComments.Text;

                string ifEditing = editingEntry ? "Edited " : "";

                DialogResult dr = MessageBox.Show("Do you want to save this " + ifEditing + "entry?", "Save Entry?", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    if (editingEntry)
                    {
                        Years[selectedYear].RemoveAt(selectedEntryIndex);
                        PopulateDGVRow(dgv.Rows[selectedRowIndex], newEntry);
                        editingEntry = false;
                        editedEntryCount++;
                        lblEditedEntries.Text = editedEntryCount.ToString();
                        lblEditedEntries.Visible = true;
                    }
                    else
                    {
                        savedEntryCount++;
                        lblSavedEntries.Text = savedEntryCount.ToString();
                        lblSavedEntries.Visible = true;
                    }
                    AddEntrytoYear(newEntry);
                }
                PopulateInputFields(new Entry());

                btnEditEntry.Text = "Edit";
                btnDeleteEntry.Enabled = true;
                btnEditEntry.Enabled = true;
            }
        }

        private bool LoadMonthData(string month)
        {
            if (selectedYear == null) lblNoData.Visible = true;

            else
            {
                cmbxMostActive.Items.Clear();
                dgv.Rows.Clear();
                lblStatsFor.Text = "  Stats for " + month + " " + selectedYear;
                lblStatsForActivity.Text = month + " " + selectedYear;

                string monthNum = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month.ToString();

                GetStats(monthNum);

                if (statList.Dates.Count() > 0)
                {
                    if (pnlNewEntry.Visible == true) CalendarToGrid();

                    DisplayStats();
                }
                else
                {
                    lblNoData.Text = "No data available for " + month + " " + selectedYear;
                    lblNoData.Visible = true;
                    ResetStatLabels();
                }
            }
            return lblNoData.Visible;
        }

        public void CalendarToGrid()
        {
            pnlMonths.Visible = pnlMonths.Visible ? false : true;
            dgv.Visible = dgv.Visible ? false : true;

            btnCalendartoGrid.Text = pnlMonths.Visible ? "Data Grid" : "Calendar";
            lblNoData.Visible = false;
        }

        private void txtbxProjectSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SearchforProject();
        }

        private void SearchforProject()
        {
            string searchee = txtbxProjectSearch.Text;

            GetStats(searchee);

            if (statList.Dates.Count() == 0) MessageBox.Show("Could not find any entries for \"" + searchee + "\"", "Activity not found");
            else
            {
                lblStatsFor.Text = "  Stats for " + searchee;
                lblStatsForActivity.Text = "Months";
                DisplayStats();
            }
            txtbxProjectSearch.Clear();
        }

    }
}
