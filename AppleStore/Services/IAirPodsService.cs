namespace AppleStore.Services
{
    public interface IAirPodsService
    {
        void AddToCart(int id, int amount);
        void DeleteFromCart(int id, string table);
    }
}
