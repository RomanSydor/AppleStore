

using AppleStore.Models;

namespace AppleStore.Repositories
{
    public interface IPurchaseRepository
    {
        void Create(Purchase customer);
        Purchase Details(int id);
        void Delete(int id);
    }
}
