﻿using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class AchPizzaComposition
    {
        public int PizzaCompositionId { get; set; }
        public int Grams { get; set; }
        public int AchPizzaIdPizza { get; set; }
        public int AchIngredientIdIngredient { get; set; }

        public AchIngredient AchIngredientIdIngredientNavigation { get; set; }
        public AchPizza AchPizzaIdPizzaNavigation { get; set; }
    }
}
