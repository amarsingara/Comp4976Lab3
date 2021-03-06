﻿using System;
using System.Collections.Generic;

namespace Lab3.Models.Toons
{
    public partial class Teams
    {
        public Teams()
        {
            Players = new HashSet<Players>();
        }

        public string TeamName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Players> Players { get; set; }
    }
}
