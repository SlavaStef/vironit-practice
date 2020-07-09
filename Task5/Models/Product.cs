using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task5.Models
{
    public class Product
    {        
        public int Id { get; set; }

        [Required(ErrorMessage = "Name required")]
        [MaxLength(30, ErrorMessage = "Name length is 1 to 30")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price required")]
        [Range(typeof(decimal), "0,01", "999999,99", ErrorMessage = "Price is more than 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Description required")]
        [MinLength(20, ErrorMessage = "Description length is 20 to 200")]
        public string Description { get; set; }

        public Categories Category { get; set; }
    }

    public enum Categories
    {
        Laptop,
        Tablet
    }
}