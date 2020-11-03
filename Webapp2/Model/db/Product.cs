using System;
using System.Collections.Generic;

namespace Webapp2.Model.db
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double? ProductPrice { get; set; }
        public int? UnitStock { get; set; }
    }
}
