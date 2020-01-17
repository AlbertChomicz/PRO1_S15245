using System;
using System.Collections.Generic;

namespace PIZZA_API.Models
{
    public partial class AcPizzaOrder
    {
        public int Id { get; set; }
        public int AcAddressesId { get; set; }
        public int AcUsersId { get; set; }
        public int? AcIngredientsId { get; set; }
        public DateTime Date { get; set; }

        public AcAddresses AcAddresses { get; set; }
        public AcIngredients AcIngredients { get; set; }
        public AcUsers AcUsers { get; set; }
    }
}
