using System;
using System.Collections.Generic;

namespace Lab6.Context
{
    public partial class Penalty
    {
        public int PenaltyId { get; set; }
        public int DriverId { get; set; }
        public int ViolationId { get; set; }
        public DateTime Date { get; set; }

        public virtual Driver Driver { get; set; } = null!;
        public virtual Violation Violation { get; set; } = null!;
    }
}
