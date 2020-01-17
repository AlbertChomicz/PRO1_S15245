using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class AchOrder
    {
        public int IdOrder { get; set; }
        public int AchCustomerIdCustomer { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderStatus { get; set; }

        public AchCustomer AchCustomerIdCustomerNavigation { get; set; }
    }
}
