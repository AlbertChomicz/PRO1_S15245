using System;
using System.Collections.Generic;

namespace API_PIZZA.Models
{
    public partial class StopnieTytuly
    {
        public StopnieTytuly()
        {
            Dydaktyk = new HashSet<Dydaktyk>();
        }

        public int IdStopien { get; set; }
        public string Stopien { get; set; }
        public string Skrot { get; set; }

        public ICollection<Dydaktyk> Dydaktyk { get; set; }
    }
}
