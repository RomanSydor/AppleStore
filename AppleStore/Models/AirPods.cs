﻿using System.ComponentModel.DataAnnotations;

namespace AppleStore.Models
{
    public class AirPods
    {
        [Key]
        public int Id { get; set; }
        public string AirPodsModel { get; set; }
        public int YearOfProduction { get; set; }
        public bool IsWirelessCharging { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
