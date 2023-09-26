using calculatorKata;

Product p = new Product()
{
    Name = "The Little Prince",
    Price = new Price(20.25),
    UPC = 12345
};

float tax = (float)Convert.ToDouble(Console.ReadLine());

var taxCalc = new TaxCalculator(tax);

float discountPercent = (float)Convert.ToDouble(Console.ReadLine());

var discountCalc = new DiscountCalculator(discountPercent);

var discount = discountCalc.DiscountAmount(p.Price);

Console.WriteLine($"Tax amount = {taxCalc.CalculatePercentage(p.Price)}, Discount amount = {discount}");

Console.WriteLine($"Price before {p.Price}, price after {taxCalc.Calculate(p.Price)-discount}.");
Console.ReadLine();
