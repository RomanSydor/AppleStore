namespace AppleStore.Services
{
    public interface IIPadService
    {
        void AddToCart(int id, int amount);
        void DeleteFromCart(int id, string table);
    }
}
