using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFCore2.Models{
    [Table("Category")]
    public class Category{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId {get;set;}
        public string CategoryName {get;set;}
        public List<Product> Products {get;set;}
        // public ICollection<Product> Products{get;set;}
    }
}