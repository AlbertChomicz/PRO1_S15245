using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AcPizzas
    {
        public AcPizzas()
        {
            AcPizzaIngredients = new HashSet<AcPizzaIngredients>();
            AcPizzasSize = new HashSet<AcPizzasSize>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<AcPizzaIngredients> AcPizzaIngredients { get; set; }
        public ICollection<AcPizzasSize> AcPizzasSize { get; set; }
    }
}
