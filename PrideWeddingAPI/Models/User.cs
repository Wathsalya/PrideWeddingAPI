using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingAPI.Models
{
    public class User : IdentityUser

    {
        public string ClientNIC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCategory { get; set; }
    }
}