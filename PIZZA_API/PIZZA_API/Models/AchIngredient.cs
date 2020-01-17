using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class AchIngredient
    {
        public AchIngredient()
        {
            AchCustomerAlergen = new HashSet<AchCustomerAlergen>();
            AchPizzaComposition = new HashSet<AchPizzaComposition>();
        }

        public int IdIngredient { get; set; }
        public string Name { get; set; }
        public int Alergen { get; set; }

        public ICollection<AchCustomerAlergen> AchCustomerAlergen { get; set; }
        public ICollection<AchPizzaComposition> AchPizzaComposition { get; set; }
    }
}
