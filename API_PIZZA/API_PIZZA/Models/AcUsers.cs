using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AcUsers
    {
        public AcUsers()
        {
            AcPizzaOrder = new HashSet<AcPizzaOrder>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }

        public ICollection<AcPizzaOrder> AcPizzaOrder { get; set; }
    }
}
