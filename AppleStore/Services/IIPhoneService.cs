using AppleStore.Models;

namespace AppleStore.Services
{
    public interface IIPhoneService
    {
        void AddToCart(int id, int amount);
        void DeleteFromCart(int id, string table);
    }
}
