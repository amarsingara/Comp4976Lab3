using System;
using System.Collections.Generic;

namespace Lab3.Models.Toons
{
    public partial class Vehicles
    {
        public string Model { get; set; }
        public string Fuel { get; set; }
        public string Type { get; set; }
        public string VehicleManufacturerName { get; set; }

        public virtual VehicleManufacturers VehicleManufacturerNameNavigation { get; set; }
    }
}
