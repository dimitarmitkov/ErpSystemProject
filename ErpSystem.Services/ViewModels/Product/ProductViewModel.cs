﻿using System;
using System.Runtime.CompilerServices;
using ErpSystem.Models;

namespace ErpSystem.Services.Models
{
    public class ProductViewModel
    {

        public string ProductName { get; set; }

        public decimal ProductLandedPrice { get; set; }

        public int ProductGrossMargin { get; set; }

        public decimal ProductSalePrice { get; set; }

        public string Supplier { get; set; }

        public int TimeToOrder { get; set; }

        public int TimeToDelivery { get; set; }

        public string ProductTransportPackage { get; set; }//Pallet, box, container, ect.

        public string MeasurmentTag { get; set; }

        public int ProductsAvailable { get; set; }

        public decimal TotalProductsDeliveryPrice { get; set; }
    }
}
