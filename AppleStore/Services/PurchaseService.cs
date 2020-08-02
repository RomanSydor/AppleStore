using AppleStore.Models;
using Newtonsoft.Json;
using System;

namespace AppleStore.Services
{
    public class PurchaseService : IPurchaseService
    {
        private Purchase _purchase;
        private Cart _cart;

        public PurchaseService(Cart cart)
        {
            _cart = cart;
        }

        public Purchase Create()
        {
            if (_purchase == null) 
            {
                _purchase = new Purchase();
            }

            float tp = 0;

            foreach (var item in _cart.CartList)
            {
                tp += item.TotalPrice; 
            }

            _purchase.Date = DateTime.Now;
            var list = JsonConvert.SerializeObject(_cart.CartList);
            _purchase.BoughtProds = list;
            _purchase.TotalPrice = tp;

            _cart.CartList.Clear();

            return _purchase;
        }
    }
}
