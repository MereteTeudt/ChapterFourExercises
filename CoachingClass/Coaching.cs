using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoachingClass
{
    class Coaching
    {
        public Coaching(string type, int players, string timings, decimal charges)
        {
            Type = type;
            Players = players;
            Timings = timings;
            Charges = charges;
        }

        private string Type { get; set; }
        private int Players { get; set; }
        private string Timings { get; set; }
        private decimal Charges { get; set; }

        public string DisplayDetails()
        {
            return $"type\t     players\ttimings\tcharges\n{Type}\t{Players}\t{Timings}\t{Charges}";
        }
    }
}
