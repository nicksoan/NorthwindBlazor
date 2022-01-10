using System;
using System.Collections.Generic;

namespace NorthwindBlazor.Lib.Models.Entity
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
