using LearnBlazorApp.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazorApp.Services.Implementations
{
    public class ShoppingCartService : IShoppingCartService
    {
        ObservableCollection<Product> CartItems;
        public ShoppingCartService()
        {
            CartItems = new ObservableCollection<Product>();
        }
        public void AddToCart(Product product)
        {
            CartItems.Add(product);
        }

        public bool CanCheckout()
        {
            if (GetItemsCountInCart() < 1)
                return false;
            return true;
        }

        public ObservableCollection<Product> GetCartItems()
        {
            return CartItems;
        }

        public Task<ObservableCollection<Product>> GetCartItemsAsync()
        {
            return Task.Run(() =>
               {
                   return GetCartItems();
               });

        }

        public int GetItemsCountInCart()
        {
            return CartItems.Count;
        }

        public double GetTotalCost()
        {
            if (GetItemsCountInCart() < 1)
                return 0;
            return CartItems.Sum(x => x.Quantity * x.SellingPrice);
        }

        public double GetTotalTax()
        {
            return GetTotalCost() * (GetTaxationRate() / 100);
        }

        public double GetTaxationRate()
        {
            return 16;
        }

        public void RemoveFromCart(Product product)
        {
            CartItems.Remove(product);
        }
    }
}
