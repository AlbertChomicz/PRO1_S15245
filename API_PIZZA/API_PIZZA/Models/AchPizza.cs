using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AchPizza
    {
        public AchPizza()
        {
            AchOrderPizza = new HashSet<AchOrderPizza>();
            AchPizzaComposition = new HashSet<AchPizzaComposition>();
        }

        public int IdPizza { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Type { get; set; }

        public ICollection<AchOrderPizza> AchOrderPizza { get; set; }
        public ICollection<AchPizzaComposition> AchPizzaComposition { get; set; }
    }
}
