using AppleStore.Models;
using System.Linq;

namespace AppleStore.Services
{
    public class MacService : IMacService
    {
        private DataContext _dataContext;
        private Cart _cart;

        public MacService(DataContext dataContext, Cart cart)
        {
            _dataContext = dataContext;
            _cart = cart;
        }

        public void AddToCart(int id, int amount)
        {
            Product existMac = null;
            var mac = _dataContext.Macs
                .SingleOrDefault(i => i.Id == id);

            foreach (var item in _cart.CartList)
            {
                if (item.ProductId == mac.Id && item.TableName == "Macs")
                {
                    existMac = _cart.CartList
                        .SingleOrDefault(i => i.ProductId == item.ProductId
                        && i.TableName == item.TableName);
                }
            }

            if (existMac != null)
            {
                existMac.Amount += amount;
                existMac.TotalPrice += amount * existMac.Price;
                mac.AmountOfProduct -= amount;
            }
            else
            {
                var cartItem = new Product();
                cartItem.ProductId = mac.Id;
                cartItem.TableName = "Macs";
                cartItem.ProductName = mac.MacModel;
                cartItem.Color = mac.Color;
                cartItem.ScreenSize = mac.ScreenSize;
                cartItem.Memory = mac.Memory;
                cartItem.Amount = amount;
                cartItem.Price = mac.Price;
                cartItem.TotalPrice += amount * mac.Price;

                _cart.CartList.Add(cartItem);

                mac.AmountOfProduct -= amount;
            }

            _dataContext.SaveChanges();
        }

        public void DeleteFromCart(int id, string table)
        {
            var mac = _dataContext.Macs
                .SingleOrDefault(i => i.Id == id);

            var cartItem = _cart.CartList
                .SingleOrDefault(i => i.ProductId == id
                && i.TableName == table);

            _cart.CartList.Remove(cartItem);

            cartItem.TotalPrice -= cartItem.Amount * cartItem.Price;
            mac.AmountOfProduct += cartItem.Amount;
            _dataContext.SaveChanges();
        }
    }
}
