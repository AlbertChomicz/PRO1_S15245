using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AcIngredients
    {
        public AcIngredients()
        {
            AcPizzaIngredients = new HashSet<AcPizzaIngredients>();
            AcPizzaOrder = new HashSet<AcPizzaOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Carbohydrate { get; set; }

        public ICollection<AcPizzaIngredients> AcPizzaIngredients { get; set; }
        public ICollection<AcPizzaOrder> AcPizzaOrder { get; set; }
    }
}
