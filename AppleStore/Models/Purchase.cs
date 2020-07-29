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
        public string FirstName { get; set; }
    
        [JsonProperty]
        public string LastName { get; set; }
     
        [JsonProperty]
        public string PhoneNumber { get; set; }
     
        [JsonProperty]
        public string Email { get; set; }
       
        [JsonProperty]
        public DateTime Date { get; set; }
       
        [JsonProperty]
        public float TotalPrice { get; set; }
      
        [JsonProperty]
        public string BoughtProds { get; set; }
    }
}
