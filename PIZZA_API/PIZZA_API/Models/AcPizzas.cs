using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class AcPizzas
    {
        public AcPizzas()
        {
            AcPizzaDetails = new HashSet<AcPizzaDetails>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AcPizzaDetails> AcPizzaDetails { get; set; }
    }
}
