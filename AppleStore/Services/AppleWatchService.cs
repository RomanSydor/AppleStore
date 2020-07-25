using AppleStore.Models;
using System.Linq;

namespace AppleStore.Services
{
    public class AppleWatchService : IAppleWatchService
    {
        private DataContext _dataContext;
        private Cart _cart;

        public AppleWatchService(DataContext dataContext, Cart cart)
        {
            _dataContext = dataContext;
            _cart = cart;
        }

        public void AddToCart(int id, int amount)
        {
            var watch = _dataContext.AppleWatches
                .SingleOrDefault(i => i.Id == id);

            var cartItem = new Product();
            cartItem.ProductId = watch.Id;
            cartItem.TableName = "AppleWatches";
            cartItem.ProductName = watch.AppleWatchModel;
            cartItem.Color = watch.Color;
            cartItem.ScreenSize = watch.ScreenSize;
            cartItem.Amount = amount;
            cartItem.Price = watch.Price;
            cartItem.TotalPrice += amount * watch.Price;

            _cart.CartList.Add(cartItem);

            watch.AmountOfProduct -= amount;
            _dataContext.SaveChanges();
        }

        public void DeleteFromCart(int id, string table)
        {
            var watch = _dataContext.AppleWatches
               .SingleOrDefault(i => i.Id == id);

            var cartItem = _cart.CartList
                .SingleOrDefault(i => i.ProductId == id
                && i.TableName == table);

            _cart.CartList.Remove(cartItem);

            cartItem.TotalPrice -= cartItem.Amount * cartItem.Price;
            watch.AmountOfProduct += cartItem.Amount;
            _dataContext.SaveChanges();
        }
    }
}
