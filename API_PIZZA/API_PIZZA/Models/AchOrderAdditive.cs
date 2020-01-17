using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class AchOrderAdditive
    {
        public int Amount { get; set; }
        public int AchAdditiveIdAdditive { get; set; }
        public int AchOrderIdOrder { get; set; }
        public int IdOrderAddiive { get; set; }

        public AchAdditive AchAdditiveIdAdditiveNavigation { get; set; }
        public AchOrder AchOrderIdOrderNavigation { get; set; }
    }
}
