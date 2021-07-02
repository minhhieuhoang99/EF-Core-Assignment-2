using EFCore2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace EFCore2.Services
{
    public class ProductServices : IProductServices
    {
        ProductContext productContext;
        public ProductServices(ProductContext _productContext)
        {
            productContext = _productContext;
        }
        public List<Product> GetProduct()
        {
            if (productContext != null)
            {
                return productContext.Products.ToList();
            }
            return null;
        }
        public Product Add(ProductDTO product)
        {    // 1 12 38 
            using var trancsaction = productContext.Database.BeginTransaction();
            try
            {
                var newProduct = new Product
                {
                    ProductName = product.ProductName,
                    Manufacture = product.Manufacture,
                    CategoryId = product.CategoryId
                };

                productContext.Products.Add(newProduct);
                productContext.SaveChanges();
                trancsaction.Commit();

                return newProduct;
            }
            catch
            {
                throw;
            }
        }
        public Product Update(ProductDTO product)
        {
            using var trancsaction = productContext.Database.BeginTransaction();
            try
            {
                var existingProduct = productContext.Products.Find(product.ID);
                if (existingProduct != null)
                {
                    existingProduct.ProductName = product.ProductName;
                    existingProduct.Manufacture = product.Manufacture;
                    existingProduct.CategoryId = product.ID;
                    productContext.SaveChanges();
                    trancsaction.Commit();

                    return existingProduct;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int Delete(int id)
        {
            using var trancsaction = productContext.Database.BeginTransaction();
            try
            {
                int result = 0;
            if (productContext != null)
            {
                var existingProduct = productContext.Products.Find(id);
                if (existingProduct != null)
                {
                    productContext.Products.Remove(existingProduct);
                    result = productContext.SaveChanges();
                    trancsaction.Commit();
                    return result;
                }
                else
                {
                    return 0;
                }
            }
            return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
