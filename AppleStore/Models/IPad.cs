using System.ComponentModel.DataAnnotations;

namespace AppleStore.Models
{
    public class IPad
    {
        [Key]
        public int Id { get; set; }
        public string IPadModel { get; set; }
        public string Type { get; set; }
        public int Memory { get; set; }
        public bool IsCellular { get; set; }
        public float ScreenSize { get; set; }
        public int YearOfProduction { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
