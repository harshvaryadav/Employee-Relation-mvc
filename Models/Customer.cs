using System;
using System.Collections.Generic;

namespace Employee_Relation.Models
{
    public partial class Customer
    {
        public Customer()
        {
            TransactionVrms = new HashSet<TransactionVrm>();
        }

        public int Userid { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;

        public virtual ICollection<TransactionVrm> TransactionVrms { get; set; }
    }
}
