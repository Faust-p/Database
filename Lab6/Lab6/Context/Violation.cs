using System;
using System.Collections.Generic;

namespace Lab6.Context
{
    public partial class Violation
    {
        public Violation()
        {
            Penalties = new HashSet<Penalty>();
        }

        public int ViolationId { get; set; }
        public string ViolationName { get; set; } = null!;
        public decimal? Fine { get; set; }

        public virtual ICollection<Penalty> Penalties { get; set; }
    }
}
