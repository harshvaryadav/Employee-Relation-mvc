using System;
using System.Collections.Generic;

namespace Employee_Relation.Models
{
    public partial class AvaniOrder
    {
        public int OrderId { get; set; }
        public int OrderNumber { get; set; }
        public int? PersonId { get; set; }

        public virtual AvaniPerson? Person { get; set; }
    }
}
