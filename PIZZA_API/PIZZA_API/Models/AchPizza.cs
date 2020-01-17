using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class AchPizza
    {
        public AchPizza()
        {
            AchPizzaComposition = new HashSet<AchPizzaComposition>();
        }

        public int IdPizza { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public ICollection<AchPizzaComposition> AchPizzaComposition { get; set; }
    }
}
