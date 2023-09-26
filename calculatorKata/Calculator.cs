namespace calculatorKata
{
    internal class PercentageCalculator
    {
        readonly double percentage;

        public PercentageCalculator(double percentage)
        {
            this.percentage = percentage;
        }


        public Price CalculatePercentage(Price price)
        {
            return price * (percentage / 100);
        }
    }
}