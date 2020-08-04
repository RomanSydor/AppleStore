using AppleStore.Models;

namespace AppleStore.Services
{
    public interface IPurchaseService
    {
        Purchase Create();
        void ClearList();
        void CountPrice(string promo);
    }
}
