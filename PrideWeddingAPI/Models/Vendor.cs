using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingAPI.Models
{
    public class Vendor
    {
        [Key]
        public int ID { get; set; }
        public string CompanyName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string TelephoneNo { get; set; }
        public string CompanyCategory { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}