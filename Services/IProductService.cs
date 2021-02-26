using System.Collections.Generic;
using Product.Models;

namespace Product.Services
{
    public interface IProductService
    {
        Producten GetProduct(string productName);
        List<Producten> GetProducts();
        void AddProduct(Producten product);
        void DeleteProductById(int productId);
        Producten UpDateProductById(int productIdToEdit, Producten productEditValues);
    }
}
