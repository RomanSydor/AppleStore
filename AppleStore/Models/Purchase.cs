using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace AppleStore.Models
{
    [JsonObject]
    public class Purchase
    {
        [Key]
        [JsonProperty]
        public int Id { get; set; }
    
        [JsonProperty]
        [Required(ErrorMessage = "Field can't be empty.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }
    
        [JsonProperty]
        [Required(ErrorMessage = "Field can't be empty.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }
     
        [JsonProperty]
        [Required(ErrorMessage = "Field can't be empty.")]
        [Display(Name = "Phone")]
        [Phone]
        public string PhoneNumber { get; set; }
     
        [JsonProperty]
        [Required(ErrorMessage = "Field can't be empty.")]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string Email { get; set; }
       
        [JsonProperty]
        public DateTime Date { get; set; }
       
        [JsonProperty]
        public float TotalPrice { get; set; }
      
        [JsonProperty]
        public string BoughtProds { get; set; }
    }
}
