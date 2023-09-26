namespace calculatorKata
{
    internal class Calculator
    {
        readonly double percentage;

        public Calculator(double percentage)
        {
            this.percentage = percentage;
        }

        public Price Calculate(Price price)
        {
            return price * ((percentage + 100.0) / 100.0);
        }

        public Price CalculatePercentage(Price price)
        {
            return price * (percentage / 100);
        }
    }
}