using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AcSize
    {
        public AcSize()
        {
            AcPizzasSize = new HashSet<AcPizzasSize>();
        }

        public int Id { get; set; }
        public int Size { get; set; }

        public ICollection<AcPizzasSize> AcPizzasSize { get; set; }
    }
}
