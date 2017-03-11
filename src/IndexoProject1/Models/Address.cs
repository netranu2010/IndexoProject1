using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IndexoProject1.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string StreetName { get; set; }
        public int PostNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Telephone { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
