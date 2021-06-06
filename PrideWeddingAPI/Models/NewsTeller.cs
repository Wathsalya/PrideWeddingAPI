using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace PrideWeddingAPI.Models
{
    public class NewsTeller
    {
        [Key]
        public int SubscriberID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]

        public string Email { get; set; }


    }
}
