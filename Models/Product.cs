using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proiect.Models
{
    public class Product
    {
        [Key]
        public int productId;
        [Required]
        public String title;
        [Required]
        public String description;
        public String image;
        [Required]
        public Double price;
    }
}