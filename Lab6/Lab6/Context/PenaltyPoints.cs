using System;
using System.Collections.Generic;

namespace Lab6.Context
{
    public partial class PenaltyPoints
    {
        public int PenaltyPointsId { get; set; }
        public int DriverId { get; set; }
        public DateTime Date { get; set; }
        public decimal Points { get; set; }
        public virtual Driver Driver { get; set; }
    }
}
