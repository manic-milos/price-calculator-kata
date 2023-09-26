using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorKata
{
    internal class TaxCalculator : PercentageCalculator, IApplicableToPrice
    {

        public TaxCalculator(double tax)
            : base(tax)
        {
        }

        public Price Apply(Price price)
        {
            return price + CalculatePercentage(price);
        }

    }
}
