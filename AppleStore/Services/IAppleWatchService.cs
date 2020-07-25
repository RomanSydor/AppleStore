namespace AppleStore.Services
{
    public interface IAppleWatchService
    {
        void AddToCart(int id, int amount);
        void DeleteFromCart(int id, string table);
    }
}
