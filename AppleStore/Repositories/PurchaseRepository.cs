using AppleStore.Models;
using Microsoft.EntityFrameworkCore;

namespace AppleStore.Repositories
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private DataContext _dataContext;

        public PurchaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(Purchase purchase)
        {
            _dataContext.Purchases.Add(purchase);
            _dataContext.SaveChanges();
        }
    }
}
