using System;
using System.Collections.Generic;

namespace Employee_Relation.Models
{
    public partial class RahulUser
    {
        public RahulUser()
        {
            RahulBookings = new HashSet<RahulBooking>();
        }

        public int Userid { get; set; }
        public string Username { get; set; } = null!;
        public string Userpassword { get; set; } = null!;

        public virtual ICollection<RahulBooking> RahulBookings { get; set; }
    }
}
