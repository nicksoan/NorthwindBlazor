﻿using System;
using System.Collections.Generic;

namespace NorthwindBlazor.Lib.Models.Entity
{
    public partial class CurrentProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
