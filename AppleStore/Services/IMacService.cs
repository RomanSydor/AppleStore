
namespace AppleStore.Services
{
    public interface IMacService
    {
        void AddToCart(int id, int amount);
        void DeleteFromCart(int id, string table);
    }
}
