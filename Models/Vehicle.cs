using System;
using System.Collections.Generic;

namespace Employee_Relation.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            TransactionVrms = new HashSet<TransactionVrm>();
        }

        public int VehicleId { get; set; }
        public string ModelName { get; set; } = null!;
        public string RegistrationNumber { get; set; } = null!;
        public string VehicleType { get; set; } = null!;
        public int DailyRent { get; set; }
        public int IsAvailable { get; set; }
        public int KmsTravelled { get; set; }

        public virtual ICollection<TransactionVrm> TransactionVrms { get; set; }
    }
}
