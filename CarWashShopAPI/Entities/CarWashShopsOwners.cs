﻿namespace CarWashShopAPI.Entities
{
    public class CarWashShopsOwners
    {
        public int CarWashShopId { get; set; }
        public CarWashShop CarWashShop { get; set; }
        public string OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}

