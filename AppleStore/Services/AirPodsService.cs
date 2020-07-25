using AppleStore.Models;
using System.Linq;

namespace AppleStore.Services
{
    public class AirPodsService : IAirPodsService
    {
        private DataContext _dataContext;
        private Cart _cart;

        public AirPodsService(DataContext dataContext, Cart cart)
        {
            _dataContext = dataContext;
            _cart = cart;
        }

        public void AddToCart(int id, int amount)
        {
            var pods = _dataContext.AirPodses
                .SingleOrDefault(i => i.Id == id);

            var cartItem = new Product();
            cartItem.ProductId = pods.Id;
            cartItem.TableName = "AirPodses";
            cartItem.ProductName = pods.AirPodsModel;
            cartItem.Amount = amount;
            cartItem.Price = pods.Price;
            cartItem.TotalPrice += amount * pods.Price;

            _cart.CartList.Add(cartItem);

            pods.AmountOfProduct -= amount;
            _dataContext.SaveChanges();
        }

        public void DeleteFromCart(int id, string table)
        {
            var pods = _dataContext.AirPodses
               .SingleOrDefault(i => i.Id == id);

            var cartItem = _cart.CartList
                .SingleOrDefault(i => i.ProductId == id
                && i.TableName == table);

            _cart.CartList.Remove(cartItem);

            cartItem.TotalPrice -= cartItem.Amount * cartItem.Price;
            pods.AmountOfProduct += cartItem.Amount;
            _dataContext.SaveChanges();
        }
    }
}
