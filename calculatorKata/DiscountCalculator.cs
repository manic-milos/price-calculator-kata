using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorKata
{
    internal class DiscountCalculator : PercentageCalculator, IApplicableToPrice
    {
        public DiscountCalculator(double percentage) : base(percentage)
        {
        }
        public Price Apply(Price price)
        {
            return price-CalculatePercentage(price);
        }
    }
}
