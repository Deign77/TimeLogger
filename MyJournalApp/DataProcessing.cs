using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLogger
{
    public partial class TimeLogger
    {
        private void AddEntrytoYear(Entry entry)
        {
            string entryYear = entry.Date.Substring(6, 4);
            if (!Years.ContainsKey(entryYear)) Years.Add(entryYear, new List<Entry>());
            Years[entryYear].Add(entry);
        }

        public void AddEntryToStats(Entry entry)
        {
            statList.Dates.Add(entry.Date);
            statList.Activities.Add(entry.Activity);
            statList.HoursWorked.Add(entry.Hours);
            statList.Achievements.Add(entry.Achievements);
            statList.Comments.Add(entry.Comments);

            statEntryList.Add(entry);
        }

        private void PopulateInputFields(Entry entry)
        {
            txtbxDate.Text = entry.Date;
            txtbxActivity.Text = entry.Activity;
            txtbxHours.Text = (entry.Hours == 0) ? "" : entry.Hours.ToString();
            txtbxAchievements.Text = entry.Achievements;
            txtbxComments.Text = entry.Comments;
        }

        public void PopulateDGVRow(DataGridViewRow row, Entry entry)
        {
            row.Cells[0].Value = entry.Date;
            row.Cells[1].Value = entry.Activity;
            row.Cells[2].Value = entry.Hours;
            row.Cells[3].Value = entry.Achievements;
            row.Cells[4].Value = entry.Comments;
        }

        private void SaveToFile()
        {
            DialogResult dr = MessageBox.Show("Save " + savedEntryCount + " new entries, " + editedEntryCount + " edits & " + deletedEntryCount + " deletions?", "Save changes to file?", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                savedEntryCount = deletedEntryCount = editedEntryCount = 0;
                lblSavedEntries.Text = lblEditedEntries.Text = lblDeletedEntries.Text = "";

                JArray jArray = new JArray();

                foreach (KeyValuePair<string, List<Entry>> kvp in Years)
                {
                    Entry[] orderedEntries = kvp.Value.OrderBy(x => x.Date).ToArray();

                    for (int i = 0; i < orderedEntries.Count(); i++)
                    {
                        string jObjectEntry = JsonConvert.SerializeObject(orderedEntries[i]);
                        jArray.Add(jObjectEntry);
                    }
                }
                File.WriteAllText(path, jArray.ToString());
            }
        }

        private DialogResult EditOrDeleteEntry(int rowIndex, string editOrDelete)
        {
            if (selectedRowIndex >= 0)
            {
                selectedEntryIndex = FindEntry(selectedRowIndex);

                Entry toEOD = Years[selectedYear][selectedEntryIndex];

                string toEODConfirm = string.Format("Are you sure you want to " + editOrDelete + " this entry? \n\nDate: {0} \nActivity: {1} \nHours: {2} \nAchievements: {3} \nComments: {4}", toEOD.Date, toEOD.Activity, toEOD.Hours, toEOD.Achievements, toEOD.Comments);

                DialogResult confirmEOD = MessageBox.Show(toEODConfirm, "Confirm entry to " + editOrDelete, MessageBoxButtons.YesNo);

                return confirmEOD;
            }
            else return DialogResult.No;
        }

        private int FindEntry(int rowIndex)
        {
            for (int i = 0; i < Years[selectedYear].Count(); i++)
            {
                if (Years[selectedYear][i].Date == (string)dgv.Rows[selectedRowIndex].Cells[0].Value)
                {
                    if (Years[selectedYear][i].Activity == (string)dgv.Rows[selectedRowIndex].Cells[1].Value)
                        return i;
                }
            }
            return 0;
        }
    }
}
