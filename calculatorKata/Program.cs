using calculatorKata;

Product p = new Product()
{
    Name = "The Little Prince",
    Price = new Price(20.25),
    UPC = 12345
};

Console.Write("Tax= ");
float tax = (float)Convert.ToDouble(Console.ReadLine());

var taxCalc = new TaxCalculator(tax);
Console.Write("discount= ");
float discountPercent = (float)Convert.ToDouble(Console.ReadLine());

var discountCalc = new DiscountCalculator(discountPercent);

var reporter=new Reporter(taxCalc, discountCalc);
reporter.Apply(p.Price);

Console.ReadLine();
