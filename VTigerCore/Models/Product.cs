using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VTigerCore.Models
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public bool ProductActive { get; set; }
        public float UnitPrice { get; set; }
        public float Taxes { get; set; }
        public int QTStock { get; set; }
        public string handler { get; set; }


    }
}
