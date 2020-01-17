using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class AcIngredients
    {
        public AcIngredients()
        {
            AcPizzaDetails = new HashSet<AcPizzaDetails>();
            AcPizzaOrder = new HashSet<AcPizzaOrder>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }
        public int Carbohydrate { get; set; }

        public ICollection<AcPizzaDetails> AcPizzaDetails { get; set; }
        public ICollection<AcPizzaOrder> AcPizzaOrder { get; set; }
    }
}
