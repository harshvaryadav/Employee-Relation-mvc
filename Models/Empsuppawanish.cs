﻿using System;
using System.Collections.Generic;

namespace Employee_Relation.Models
{
    public partial class Empsuppawanish
    {
        public Empsuppawanish()
        {
            Empawanishes = new HashSet<Empawanish>();
        }

        public int SId { get; set; }
        public string? Sname { get; set; }

        public virtual ICollection<Empawanish> Empawanishes { get; set; }
    }
}
