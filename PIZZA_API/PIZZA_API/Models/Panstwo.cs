using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class Panstwo
    {
        public Panstwo()
        {
            Miasto = new HashSet<Miasto>();
        }

        public int IdPanstwo { get; set; }
        public string Panstwo1 { get; set; }

        public ICollection<Miasto> Miasto { get; set; }
    }
}
