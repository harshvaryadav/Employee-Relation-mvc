using System;
using System.Collections.Generic;

namespace Employee_Relation.Models
{
    public partial class ManasFerry
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int RoomsLeft { get; set; }
        public double Charge { get; set; }
        public string? Image { get; set; }
        public DateTime Departure { get; set; }
        public int OriginId { get; set; }
        public int DestinationId { get; set; }
    }
}
