using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AchOrderPizza
    {
        public int Amount { get; set; }
        public int PizzaSize { get; set; }
        public int PizzaDough { get; set; }
        public int AchOrderIdOrder { get; set; }
        public int AchPizzaIdPizza { get; set; }
        public int IdOrderPizza { get; set; }

        public AchOrder AchOrderIdOrderNavigation { get; set; }
        public AchPizza AchPizzaIdPizzaNavigation { get; set; }
    }
}
