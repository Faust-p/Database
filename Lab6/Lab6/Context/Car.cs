using System;
using System.Collections.Generic;

namespace Lab6.Context
{
    public partial class Car
    {
        public int CarId { get; set; }
        public int DriverId { get; set; }
        public string PlateNumber { get; set; } = null!;
        public string Brand { get; set; } = null!;

        public virtual Driver Driver { get; set; } = null!;
    }
}
