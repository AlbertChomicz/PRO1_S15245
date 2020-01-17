using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class RokAkademicki
    {
        public RokAkademicki()
        {
            Grupa = new HashSet<Grupa>();
        }

        public string IdRokAkademicki { get; set; }
        public DateTime DataRozp { get; set; }
        public DateTime DataZak { get; set; }

        public ICollection<Grupa> Grupa { get; set; }
    }
}
