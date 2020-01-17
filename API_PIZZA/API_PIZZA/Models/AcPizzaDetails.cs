using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AcPizzaDetails
    {
        public int Id { get; set; }
        public int AcIngredientsId { get; set; }
        public int AcPizzasId { get; set; }
        public int AcSizeId { get; set; }
        public int AcPizzaPieId { get; set; }
        public int Pirce { get; set; }

        public AcIngredients AcIngredients { get; set; }
        public AcPizzaPie AcPizzaPie { get; set; }
        public AcPizzas AcPizzas { get; set; }
        public AcSize AcSize { get; set; }
    }
}
