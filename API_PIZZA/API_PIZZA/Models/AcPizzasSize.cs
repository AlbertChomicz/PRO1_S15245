using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AcPizzasSize
    {
        public AcPizzasSize()
        {
            AcPizzaOrder = new HashSet<AcPizzaOrder>();
        }

        public int Id { get; set; }
        public int AcPizzasId { get; set; }
        public int AcSizeId { get; set; }

        public AcPizzas AcPizzas { get; set; }
        public AcSize AcSize { get; set; }
        public ICollection<AcPizzaOrder> AcPizzaOrder { get; set; }
    }
}
