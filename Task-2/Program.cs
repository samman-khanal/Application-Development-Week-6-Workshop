public class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Addition: " + calc.Add(5, 3));
        Console.WriteLine("Subtraction: " + calc.Subtract(10, 4));

        double price = 1000;
        Console.WriteLine("\nOriginal Price: " + price);
        DiscountStrategy discount;

        discount = calc.FestivalDiscount;
        Console.WriteLine("Price after Festival Discount: " + discount(price));

        discount = calc.SeasonalDiscount;
        Console.WriteLine("Price after Seasonal Discount: " + discount(price));

        discount = calc.NoDiscount;
        Console.WriteLine("Price with No Discount: " + discount(price));
    }
}
