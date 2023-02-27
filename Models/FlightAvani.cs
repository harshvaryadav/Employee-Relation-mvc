using System;
using System.Collections.Generic;

namespace Employee_Relation.Models
{
    public partial class FlightAvani
    {
        public int FlightNo { get; set; }
        public DateTime? Departure { get; set; }
        public string? LeaveFrom { get; set; }
        public string? GoingTo { get; set; }
        public string? AirlinesName { get; set; }
        public string? Price { get; set; }
        public bool? StateSold { get; set; }
    }
}
