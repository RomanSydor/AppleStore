using AppleStore.Models;
using System;

namespace AppleStore.Services
{
    public class PurchaseService : IPurchaseService
    {
        //private DataContext _dataContext;

        Purchase _purchase;

        public Purchase Create() //TODO transfer Products here
        {
            if (_purchase == null) 
            {
                _purchase = new Purchase();
            }
            _purchase.Date = DateTime.Now;
            return _purchase;
        }
    }
}
