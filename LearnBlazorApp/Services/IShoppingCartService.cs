using LearnBlazorApp.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace LearnBlazorApp.Services
{
    public interface IShoppingCartService
    {
        ObservableCollection<Product> GetCartItems();
        Task<ObservableCollection<Product>> GetCartItemsAsync();
        void AddToCart(Product product);
        void RemoveFromCart(Product product);

        double GetTotalCost();
        double GetTotalTax();
        bool CanCheckout();
        int GetItemsCountInCart();
        double GetTaxationRate();
    }
}
