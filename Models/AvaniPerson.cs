using System;
using System.Collections.Generic;

namespace Employee_Relation.Models
{
    public partial class AvaniPerson
    {
        public AvaniPerson()
        {
            AvaniOrders = new HashSet<AvaniOrder>();
        }

        public int PersonId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<AvaniOrder> AvaniOrders { get; set; }
    }
}
