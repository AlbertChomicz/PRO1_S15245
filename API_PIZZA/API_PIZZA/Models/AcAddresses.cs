using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AcAddresses
    {
        public AcAddresses()
        {
            AcPizzaOrder = new HashSet<AcPizzaOrder>();
        }

        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int? FlatNumber { get; set; }
        public int PostalCode { get; set; }

        public ICollection<AcPizzaOrder> AcPizzaOrder { get; set; }
    }
}
