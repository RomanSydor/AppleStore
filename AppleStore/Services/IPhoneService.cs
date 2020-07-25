﻿using AppleStore.Models;
using System.Linq;

namespace AppleStore.Services
{
    public class IPhoneService : IIPhoneService
    {
        private DataContext _dataContext;
        private Cart _cart;

        public IPhoneService(DataContext dataContext, Cart cart)
        {
            _dataContext = dataContext;
            _cart = cart;
        }

        public void AddToCart(int id, int amount)
        {
            var iPhone = _dataContext.IPhones
                .SingleOrDefault(i => i.Id == id);

            var cartItem = new Product();
            cartItem.ProductId = iPhone.Id;
            cartItem.TableName = "IPhones";
            cartItem.ProductName = iPhone.IPhoneModel;
            cartItem.Color = iPhone.Color;
            cartItem.Memory = iPhone.Memory;
            cartItem.Amount = amount;
            cartItem.Price = iPhone.Price;
            cartItem.TotalPrice += amount * iPhone.Price;

            _cart.CartList.Add(cartItem);

            iPhone.AmountOfProduct -= amount;
            _dataContext.SaveChanges();
        }

        public void DeleteFromCart(int id, string table)
        {
            var iPhone = _dataContext.IPhones
                .SingleOrDefault(i => i.Id == id);
            var cartItem = _cart.CartList
                .SingleOrDefault(i => i.ProductId == id 
                && i.TableName == table);

            _cart.CartList.Remove(cartItem);

            cartItem.TotalPrice -= cartItem.Amount * cartItem.Price;
            iPhone.AmountOfProduct += cartItem.Amount;
            _dataContext.SaveChanges();
        }
    }
}
