using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFCore2.Models
{
    public class ProductDTO
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string Manufacture { get; set; }
        public int ID { get; set; }
    }
}