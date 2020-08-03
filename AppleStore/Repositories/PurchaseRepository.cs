using AppleStore.Models;
using System.Linq;

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

        public void Delete(int id)
        {
            var pur = _dataContext.Purchases.SingleOrDefault(p => p.Id == id);

            _dataContext.Purchases.Remove(pur);
            _dataContext.SaveChanges();
        }

        public Purchase Details(int id) 
        {
            return _dataContext.Purchases.SingleOrDefault(p => p.Id == id);
        }
    }
}
