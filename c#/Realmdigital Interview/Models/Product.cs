using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Realmdigital_Interview.Models
{
    public class Product
    {
        public string BarCode { get; set; }
        public string ItemName { get; set; }
        public IEnumerable<Price> PriceRecords { get; set; }
    }
}