using Product.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Product.Models;

namespace Product.Services
{
    public class DbproductService : IProductService
    {
        public void AddProduct(Producten product)
        {
            using (var db = new ProductDbContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }

        public void DeleteProductById(int productId)
        {
            using (var db = new ProductDbContext())
            {
                var productToDelete = db.Products.FirstOrDefault(product => product.Id == productId);
                db.Products.Remove(productToDelete);
                db.SaveChanges();
            }
        }

        public Producten GetProduct(string productName)
        {
            using (var db = new ProductDbContext())
            {
                var product = db.Products.FirstOrDefault(product => product.Name == productName);
                return product;
            }
        }

        public List<Producten> GetProducts()
        {
            using (var db = new ProductDbContext())
            {
                return db.Products.ToList();
            }
        }

        public Producten UpDateProductById(int productIdToEdit, Producten productEditValues)
        {
            using (var db = new ProductDbContext())
            {
                var productToEdit = db.Products.First(product => product.Id == productIdToEdit);
                productToEdit.Price = productEditValues.Price;
                productToEdit.Name = productEditValues.Name;
                db.Products.Update(productToEdit);
                db.SaveChanges();
                return productToEdit;
            }
        }
    }
}
