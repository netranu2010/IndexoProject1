using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IndexoProject1.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        public int OrganizationNumbers { get; set; }
        public string OrganizationName { get; set; }
        public string ContactPerson { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
