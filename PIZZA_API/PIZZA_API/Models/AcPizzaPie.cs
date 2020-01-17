using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class AcPizzaPie
    {
        public AcPizzaPie()
        {
            AcPizzaDetails = new HashSet<AcPizzaDetails>();
        }

        public int Id { get; set; }
        public int Name { get; set; }

        public ICollection<AcPizzaDetails> AcPizzaDetails { get; set; }
    }
}
