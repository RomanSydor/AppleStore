namespace AppleStore.Models
{
    public interface IProduct
    {
        int Id { get; set; }
        string TableName { get; set; }
        int ProductId { get; set; }
        int Amount { get; set; }
        float Price { get; set; }
        float TotalPrice { get; set; }
    }
}
