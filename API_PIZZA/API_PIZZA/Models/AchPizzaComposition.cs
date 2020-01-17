using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AchPizzaComposition
    {
        public int PizzaCompositionId { get; set; }
        public int Amount { get; set; }
        public int AchPizzaIdPizza { get; set; }
        public int AchIngredientIdIngredient { get; set; }

        public AchIngredient AchIngredientIdIngredientNavigation { get; set; }
        public AchPizza AchPizzaIdPizzaNavigation { get; set; }
    }
}
