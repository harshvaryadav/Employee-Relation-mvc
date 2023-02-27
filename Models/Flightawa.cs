using System;
using System.Collections.Generic;

namespace Employee_Relation.Models
{
    public partial class Flightawa
    {
        public string Uid { get; set; } = null!;
        public string Uname { get; set; } = null!;
        public string? JFrom { get; set; }
        public string? JTo { get; set; }
        public DateTime? Doj { get; set; }
        public string? Cid { get; set; }

        public virtual Companyawa? CidNavigation { get; set; }
    }
}
