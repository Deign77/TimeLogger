using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLogger
{
    public partial class TimeLogger 
    {
        public string selectedYear { get; set; }
        public int selectedRowIndex { get; set; } = -1;
        public int selectedEntryIndex { get; set; }

        public int savedEntryCount { get; set; }
        public int deletedEntryCount { get; set; }
        public int editedEntryCount { get; set; }

        public bool editingEntry { get; set; } = false;

        public Stats statList { get; set; }
        public List<Entry> statEntryList { get; set; }
        public Dictionary<string, List<Entry>> Years { get; set; }

        public List<Button> yearButtons { get; set; }
        public List<Button> monthButtons { get; set; }

        public string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\AppData\MyJournalAppData.json";
    }
}
