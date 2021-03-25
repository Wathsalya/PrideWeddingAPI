using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrideWeddingAPI.Models
{
    public class Vendor : IdentityUser
    {
        public string CompanyName { get; set; }
        public string TelephoneNo { get; set; }
        public string CompanyCategory { get; set; }
        public string Address { get; set; }
    }
}

