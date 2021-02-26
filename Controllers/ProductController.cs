using Product.Db;
using Product.Models;
using Product.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("many")]
        public ActionResult<List<Producten>> GetAllProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }
        [HttpGet("one")]
        public ActionResult<Producten> GetProduct(string productName)
        {
            var product = _productService.GetProduct(productName);
            if (product == null)
            {
                return NotFound();

            }
            return Ok(product);
        }
        [HttpPost]
        public ActionResult CreateNewProduct(Producten newProduct)
        {
            _productService.AddProduct(newProduct);
            return Ok();
        }
        [HttpDelete]
        public ActionResult DeleteProductById(int productId)
        {
            _productService.DeleteProductById(productId);
            return Ok();
        }

        [HttpPut]
        public ActionResult<Producten> UpdateProductById(int productIdToEdit, Producten productEditValues)
        {
            var updatedProduct = _productService.UpDateProductById(productIdToEdit, productEditValues);
            return Ok(updatedProduct);
        }
    }
}
