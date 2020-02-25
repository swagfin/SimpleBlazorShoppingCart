using LearnBlazorApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazorApp.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Task<IEnumerable<Product>> GetAllProductsAsync();
        void AddProduct(Product product);
        void RemoveProduct(Product product);
    }
}
