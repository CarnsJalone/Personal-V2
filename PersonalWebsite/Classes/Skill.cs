using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Classes {
    public class Skill {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public DateTime StartDate { get; set; }
        public double TimeInvested { get {
                return (DateTime.Now.Date - StartDate.Date).TotalDays;
            }
        }
    }
}
