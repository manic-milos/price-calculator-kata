using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorKata
{
    internal class Reporter
    {
        private readonly TaxCalculator taxCalculator;
        private readonly DiscountCalculator discountCalculator;

        public Reporter(TaxCalculator taxCalculator, DiscountCalculator discountCalculator)
        {
            this.taxCalculator = taxCalculator;
            this.discountCalculator = discountCalculator;
        }

        public void Apply(Price price)
        {
            var discount = discountCalculator.CalculatePercentage(price);

            Console.WriteLine(taxCalculator.Apply(price) - discount);

            Console.WriteLine($"discount={discount}");
        }
    }
}
