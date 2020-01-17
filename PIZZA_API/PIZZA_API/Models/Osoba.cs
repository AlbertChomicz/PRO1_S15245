using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class Osoba
    {
        public int IdOsoba { get; set; }
        public string Nazwisko { get; set; }
        public string Imie { get; set; }
        public DateTime? DataUrodzenia { get; set; }
        public int? Idmiasto { get; set; }
        public string Plec { get; set; }

        public Miasto IdmiastoNavigation { get; set; }
        public Dydaktyk Dydaktyk { get; set; }
        public Student Student { get; set; }
    }
}
