using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrideWeddingAPI.Models
{
    public class AddingCart
    {

        [Key]
        public int CompanyID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CompanyName { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CompanyCategory { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LocatedDistrict { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LocatedProvince { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Min_package { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Max_package { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string ImageName { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string TelephoneNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CompanyWebsite { get; set; }










        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public string ImageSrc { get; set; }
    }
}
