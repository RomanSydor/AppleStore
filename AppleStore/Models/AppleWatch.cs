using System.ComponentModel.DataAnnotations;

namespace AppleStore.Models
{
    public class AppleWatch
    {
        [Key]
        public int Id { get; set; }
        public string AppleWatchModel { get; set; }
        public int ScreenSize { get; set; }
        public string Communication { get; set; }
        public string Color { get; set; }
        public string HousingMaterial { get; set; }
        public string StrapType { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
