using System;
using System.Collections.Generic;

namespace Lab3.Models.Toons
{
    public partial class Competitions
    {
        public Competitions()
        {
            Athletes = new HashSet<Athletes>();
        }

        public int CompetitionId { get; set; }
        public string EventName { get; set; }

        public virtual ICollection<Athletes> Athletes { get; set; }
    }
}
