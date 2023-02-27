using System;
using System.Collections.Generic;

namespace Employee_Relation.Models
{
    public partial class ManasTicket
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Cost { get; set; }
        public int AdultCount { get; set; }
        public int RoomNo { get; set; }
        public int FerryId { get; set; }
    }
}
