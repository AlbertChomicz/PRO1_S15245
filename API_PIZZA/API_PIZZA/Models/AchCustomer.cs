using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_PIZZA.Models
{
    public partial class AchCustomer
    {
        public AchCustomer()
        {
            AchCustomerAlergen = new HashSet<AchCustomerAlergen>();
            AchOrder = new HashSet<AchOrder>();
        }

        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Imie jest wymagane")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Telefon jest wymagany")]
        [MaxLength(10, ErrorMessage = "telefon max 10 cyfr"]
        public int Telephone { get; set; }
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string HomeNumber { get; set; }
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string City { get; set; }
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string UserLogin { get; set; }
        [Required(ErrorMessage = "Pole jest wymagane")]
        public string UserPass { get; set; }

        public ICollection<AchCustomerAlergen> AchCustomerAlergen { get; set; }
        public ICollection<AchOrder> AchOrder { get; set; }
    }
}
