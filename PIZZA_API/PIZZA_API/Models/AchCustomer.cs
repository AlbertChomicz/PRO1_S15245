using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class AchCustomer
    {
        public AchCustomer()
        {
            AchCustomerAlergen = new HashSet<AchCustomerAlergen>();
            AchOrder = new HashSet<AchOrder>();
        }

        public int IdCustomer { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Telephone { get; set; }
        public string Street { get; set; }
        public string HomeNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string UserLogin { get; set; }
        public string UserPass { get; set; }

        public ICollection<AchCustomerAlergen> AchCustomerAlergen { get; set; }
        public ICollection<AchOrder> AchOrder { get; set; }
    }
}
