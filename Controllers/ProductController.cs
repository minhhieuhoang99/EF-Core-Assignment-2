using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EFCore2.Models;
using EFCore2.Services;
namespace EFCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;
        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        [HttpGet("/product")]
        public List<Product> Get()
        {
            var result = _productServices.GetProduct();
            return result;
        }
        [HttpPost("/product")]
        public Product AddProduct(ProductDTO product)
        {
            return  _productServices.Add(product);         
        }
        [HttpPut("/product/{id}")]
        public Product UpdateProduct(ProductDTO product)
        {
            return  _productServices.Update(product);         
        }
        [HttpDelete("/product/{id}")]
        public IActionResult Delete(int id)
        {
            _productServices.Delete(id);
            return NoContent();
        }

    }
}
