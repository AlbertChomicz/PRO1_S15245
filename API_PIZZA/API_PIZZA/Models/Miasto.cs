using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class Miasto
    {
        public Miasto()
        {
            Osoba = new HashSet<Osoba>();
        }

        public int Idmiasto { get; set; }
        public string Miasto1 { get; set; }
        public int? IdpanstwoFk { get; set; }

        public Panstwo IdpanstwoFkNavigation { get; set; }
        public ICollection<Osoba> Osoba { get; set; }
    }
}
