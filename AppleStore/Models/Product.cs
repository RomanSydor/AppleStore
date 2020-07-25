namespace AppleStore.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public float? ScreenSize { get; set; }
        public string Memory { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public float TotalPrice { get; set; }
    }
}
