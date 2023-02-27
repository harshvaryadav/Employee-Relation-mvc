using System;
using System.Collections.Generic;

namespace Employee_Relation.Models
{
    public partial class EmpSatyam
    {
        public int Eid { get; set; }
        public string? Ename { get; set; }
        public int? Salary { get; set; }
        public DateTime? Doj { get; set; }
        public string? City { get; set; }
    }
}
