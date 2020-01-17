using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class AchCustomerAlergen
    {
        public int CustomerAlergenId { get; set; }
        public int AchIngredientIdIngredient { get; set; }
        public int AchCustomerIdCustomer { get; set; }

        public AchCustomer AchCustomerIdCustomerNavigation { get; set; }
        public AchIngredient AchIngredientIdIngredientNavigation { get; set; }
    }
}
