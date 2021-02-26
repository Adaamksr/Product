using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Product.Models;

namespace Product.Services
{
    public class ProductService : IProductService
    {
        List<Producten> products = new List<Producten>();

        public ProductService()
        {
            if (products.Count == 0)
            {
                var product1 = new Producten();
                product1.Name = "H1";
                product1.Price = 100000;
                products.Add(product1);
            }
        }
        public Producten GetProduct(string productName)
        {
            var product = products.FirstOrDefault(x => x.Name == productName);
            return product;
        }
        public List<Producten> GetProducts()
        {
            return products;
        }
        public void AddProduct(Producten product)
        {
            products.Add(product);
        }
        public void DeleteProductById(int productId)
        {
            throw new NotImplementedException();
        }
        public Producten UpDateProductById(int productIdToEdit, Producten productEditValues)
        {
            throw new NotImplementedException();
        }

    }
}
