using System;
using System.Collections.Generic;
using Lab6.Context.Task2;

namespace Lab6.Context
{
    public partial class Driver
    {
        public Driver()
        {
            Cars = new HashSet<Car>();
            Penalties = new HashSet<Penalty>();
            PenaltiesPoints = new HashSet<PenaltyPoints>();
        }

        public int DriverId { get; set; }
        public string LicenseNumber { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public DriverViolationCategory Category { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<Penalty> Penalties { get; set; }
        public virtual ICollection<PenaltyPoints> PenaltiesPoints { get; set; }
    }
}
