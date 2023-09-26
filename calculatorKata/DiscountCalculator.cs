using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorKata
{
    internal class DiscountCalculator : Calculator
    {
        public DiscountCalculator(double percentage) : base(-percentage)
        {
        }
        public Price DiscountAmount(Price price)
        {
            return -this.CalculatePercentage(price);
        }
    }
}
