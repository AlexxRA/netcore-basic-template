using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Product
    {
        [Key]
        public int Id { get;set; }
        [Required]
        public string Name { get;set; }
        public decimal Price { get;set; }
        public string QrCode { get;set; } 
        public int Stock { get;set; }
    }
}