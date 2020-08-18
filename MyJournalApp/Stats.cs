using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeLogger
{
    public class Stats
    {
        public List<string> Dates { get; set; }
        public List<string> Activities { get; set; }
        public List<double> HoursWorked { get; set; }
        public List<string> Achievements { get; set; }
        public List<string> Comments { get; set; }
    }
}
