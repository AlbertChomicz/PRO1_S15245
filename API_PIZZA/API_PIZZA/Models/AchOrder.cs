using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AchOrder
    {
        public AchOrder()
        {
            AchOrderAdditive = new HashSet<AchOrderAdditive>();
            AchOrderPizza = new HashSet<AchOrderPizza>();
        }

        public int IdOrder { get; set; }
        public int AchCustomerIdCustomer { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatus { get; set; }
        public int PaymentType { get; set; }

        public AchCustomer AchCustomerIdCustomerNavigation { get; set; }
        public ICollection<AchOrderAdditive> AchOrderAdditive { get; set; }
        public ICollection<AchOrderPizza> AchOrderPizza { get; set; }
    }
}
