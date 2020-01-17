using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        [Required(ErrorMessage = "Pole jest wymagane")]
        public int AchCustomerIdCustomer { get; set; }
        [Required(ErrorMessage = "Pole jest wymagane")]
        public DateTime OrderDate { get; set; }
        [DefaultValue(1)]
        public int OrderStatus { get; set; }
        [Required(ErrorMessage = "Pole jest wymagane")]
        public int PaymentType { get; set; }

        public AchCustomer AchCustomerIdCustomerNavigation { get; set; }
        public ICollection<AchOrderAdditive> AchOrderAdditive { get; set; }
        public ICollection<AchOrderPizza> AchOrderPizza { get; set; }
    }
}
