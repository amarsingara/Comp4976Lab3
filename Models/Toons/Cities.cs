using System;
using System.Collections.Generic;

namespace Lab3.Models.Toons
{
    public partial class Cities
    {
        public string CityName { get; set; }
        public int ProvinceId { get; set; }

        public virtual Provinces Province { get; set; }
    }
}
