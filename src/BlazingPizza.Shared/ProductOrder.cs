﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazingPizza
{
    public class ProductOrder
    {
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public DateTime CreatedTime { get; set; }

        public Address DeliveryAddress { get; set; } = new Address();

        public LatLong DeliveryLocation { get; set; }

        public List<WoodProduct> WoodProducts { get; set; } = new List<WoodProduct>();

        public decimal GetTotalPrice() => WoodProducts.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
