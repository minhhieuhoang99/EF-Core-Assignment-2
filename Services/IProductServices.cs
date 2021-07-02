using System;
using System.Collections.Generic;
using EFCore2.Models;
namespace EFCore2.Services{
    public interface IProductServices{
        List<Product> GetProduct();
        Product Add(ProductDTO product);
        Product Update(ProductDTO product);
        int Delete(int id);
    }
}