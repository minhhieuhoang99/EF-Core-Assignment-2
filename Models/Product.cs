using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore2.Models{
    [Table("Product")]
    public class Product{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId {get;set;}
        public string ProductName {get;set;}
        public string Manufacture {get;set;}
        public int CategoryId {get;set;}
        public Category Category {get;set;}
    }
}