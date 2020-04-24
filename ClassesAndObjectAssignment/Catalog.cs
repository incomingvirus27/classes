using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjectAssignment
{
     class Catalog
    {
        public string make { get; }
        public string model { get; }
        public int year { get; }
        public decimal salesPrice { get; }

        public Catalog(string make, string model, int year, decimal salesPrice)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.salesPrice = salesPrice;
        }

        public override string ToString() => $"Make:{this.make}\nModel:{this.model}\nYear:{this.year}\nSalesPrice:{this.salesPrice:c}";      
    } 
}
