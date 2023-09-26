namespace calculatorKata
{
    internal class Price
    {
        private readonly double price;

        public Price() { }
        public Price(double price)
        {
            this.price = double.Round(price, 2);
        }

        public static implicit operator double(Price price) { return price.price; }
        public override string ToString()
        {
            return string.Format("${0:0.00}", price);
        }
        public static Price operator *(Price price, double amount)
        {
            return new Price(price.price * double.Round(amount, 2));
        }
        public static Price operator *(Price price, float amount)
        {
            return new Price(price.price * float.Round(amount, 2));
        }

        public static Price operator +(Price price, float amount)
        {
            return new Price(price.price + float.Round(amount, 2));
        }
        public static Price operator -(Price price, float amount)
        {
            return new Price(price.price - float.Round(amount, 2));
        }
        public static Price operator -(Price price)
        {
            return new Price(-price.price);
        }

    }
}
