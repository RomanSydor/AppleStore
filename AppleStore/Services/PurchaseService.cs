using AppleStore.Models;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace AppleStore.Services
{
    public class PurchaseService : IPurchaseService
    {
        private Purchase _purchase;
        private Cart _cart;
        private DataContext _dataContext;
        private float tp = 0;

        public PurchaseService(Cart cart, DataContext dataContext)
        {
            _cart = cart;
            _dataContext = dataContext;
        }

        public void ClearList()
        {
            _cart.CartList.Clear();
        }

        public void CountPrice(string promo)
        {
            var discount = _dataContext.Discounts
                    .SingleOrDefault(c => c.Id == promo);

            if (_purchase == null)
            {
                _purchase = new Purchase();
                _purchase.PromoCode = promo;
                _purchase.PromoAmount = discount.Amount;
                _purchase.PromoValue = discount.Value;
            }

            foreach (var item in _cart.CartList)
            {
                tp += item.TotalPrice;
            }

            if (_purchase.PromoCode != null)
            {

                if (discount.Value == "%")
                {
                    tp *= 1 - (discount.Amount / 100);
                }
                else if (discount.Value == "$")
                {
                    tp -= discount.Amount;
                }

                discount.IsUsed = true;
                _dataContext.SaveChanges();
            }
        }

        public Purchase Create()
        {
            if (_purchase == null) 
            {
                _purchase = new Purchase();
            }

            _purchase.Date = DateTime.Now;
            var list = JsonConvert.SerializeObject(_cart.CartList);
            _purchase.BoughtProds = list;
            _purchase.TotalPrice = tp;

            return _purchase;
        }
    }
}
