using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class Grupa
    {
        public Grupa()
        {
            StudentGrupa = new HashSet<StudentGrupa>();
        }

        public int IdGrupa { get; set; }
        public string NrGrupy { get; set; }
        public int SemestrNauki { get; set; }
        public string IdRokAkademicki { get; set; }

        public RokAkademicki IdRokAkademickiNavigation { get; set; }
        public ICollection<StudentGrupa> StudentGrupa { get; set; }
    }
}
