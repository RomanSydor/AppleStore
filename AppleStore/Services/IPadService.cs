﻿

using AppleStore.Models;
using System.Linq;

namespace AppleStore.Services
{
    public class IPadService : IIPadService
    {
        private DataContext _dataContext;
        private Cart _cart;

        public IPadService(DataContext dataContext, Cart cart)
        {
            _dataContext = dataContext;
            _cart = cart;
        }

        public void AddToCart(int id, int amount)
        {
            Product existIPad = null;
            var iPad = _dataContext.IPads
                .SingleOrDefault(i => i.Id == id);

            foreach (var item in _cart.CartList)
            {
                if (item.ProductId == iPad.Id && item.TableName == "IPads") 
                {
                    existIPad = _cart.CartList
                        .SingleOrDefault(i => i.ProductId == item.ProductId
                        && i.TableName == item.TableName);
                }
            }

            if (existIPad != null)
            {
                existIPad.Amount += amount;
                existIPad.TotalPrice += amount * existIPad.Price;
                iPad.AmountOfProduct -= amount;
            }
            else
            {
                var cartItem = new Product();
                cartItem.ProductId = iPad.Id;
                cartItem.TableName = "IPads";
                cartItem.ProductName = iPad.IPadModel;
                cartItem.Color = iPad.Color;
                cartItem.Memory = iPad.Memory;
                cartItem.Amount = amount;
                cartItem.Price = iPad.Price;
                cartItem.TotalPrice += amount * iPad.Price;

                _cart.CartList.Add(cartItem);

                iPad.AmountOfProduct -= amount;
            }

            _dataContext.SaveChanges();
        }

        public void DeleteFromCart(int id, string table)
        {
            var iPad = _dataContext.IPads
                .SingleOrDefault(i => i.Id == id);

            var cartItem = _cart.CartList
                .SingleOrDefault(i => i.ProductId == id
                && i.TableName == table);

            _cart.CartList.Remove(cartItem);

            cartItem.TotalPrice -= cartItem.Amount * cartItem.Price;
            iPad.AmountOfProduct += cartItem.Amount;
            _dataContext.SaveChanges();
        }
    }
}
