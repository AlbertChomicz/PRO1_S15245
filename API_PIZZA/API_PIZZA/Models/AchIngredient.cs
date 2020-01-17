using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AchIngredient
    {
        public AchIngredient()
        {
            AchCustomerAlergen = new HashSet<AchCustomerAlergen>();
            AchPizzaComposition = new HashSet<AchPizzaComposition>();
        }
  
        public int IdIngredient { get; set; }
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Pole jest wymagane")]
        public int Alergen { get; set; }

        public ICollection<AchCustomerAlergen> AchCustomerAlergen { get; set; }
        public ICollection<AchPizzaComposition> AchPizzaComposition { get; set; }
    }
}
