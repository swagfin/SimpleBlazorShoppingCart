using LearnBlazorApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazorApp.Services.Implementations
{
    public class ProductService : IProductService
    {
        //Because its demo will use Single Instance
        List<Product> AllProducts;
        public ProductService()
        {
            InitiateDemoProducts();
        }


        private void InitiateDemoProducts()
        {
            AllProducts = new List<Product>();
            AllProducts.Add(new Product
            {
                ProductName = "T-Shirt Guchi",
                BarCode = "54854",
                ImageFile = "tshirt.png",
                SellingPrice = 450
            });
            AllProducts.Add(new Product
            {
                ProductName = "Jacket Gucci XL",
                BarCode = "25654",
                ImageFile = "jacket.png",
                SellingPrice = 800
            });
            AllProducts.Add(new Product
            {
                ProductName = "Trouse 4 HF",
                BarCode = "85005",
                ImageFile = "trouser.png",
                SellingPrice = 600
            });
            AllProducts.Add(new Product
            {
                ProductName = "Royal Watch 4G",
                BarCode = "52005",
                ImageFile = "watch.png",
                SellingPrice = 300
            });
            AllProducts.Add(new Product
            {
                ProductName = "loofer Shoes S42",
                BarCode = "5200",
                ImageFile = "lover.png",
                SellingPrice = 1400

            });

            AllProducts.Add(new Product
            {
                ProductName = "Towel XR",
                BarCode = "37500",
                SellingPrice = 700
            });
            AllProducts.Add(new Product
            {
                ProductName = "Sneakers White",
                BarCode = "74562",
                SellingPrice = 250
            });
            AllProducts.Add(new Product
            {
                ProductName = "Lady Guccie Top",
                BarCode = "60084",
                ImageFile = "ladygucci.png",
                SellingPrice = 300
            });
        }

        public void AddProduct(Product product)
        {
            AllProducts.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return AllProducts;
        }

        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return Task.Run(() =>
           {
               System.Threading.Thread.Sleep(1200);
               return GetAllProducts();
           });
        }

        public void RemoveProduct(Product product)
        {
            AllProducts.Remove(product);
        }
    }
}
