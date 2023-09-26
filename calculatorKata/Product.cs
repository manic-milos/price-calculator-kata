using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace calculatorKata
{
    internal class Product
    {
        public string Name { get; set; } = "";
        public int UPC { get; set; }
        public Price Price { get; set; }=new Price(0);

    }
}
