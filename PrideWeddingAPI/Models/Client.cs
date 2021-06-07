using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingAPI.Models
{
    public class Client
    {
        [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string ClientNIC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string MobileNo { get; set; }
        public string Address { get; set; }

        public string UserName { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]

        public string Email { get; set; }
    }
}