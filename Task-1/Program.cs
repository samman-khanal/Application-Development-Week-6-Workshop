public class Program
{
    public static void Main(String[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Length = 5;
        rectangle.Breadth = 3;

        Console.WriteLine(rectangle.ShowDetails());
        Console.WriteLine($"Area: {rectangle.GetArea()}");
        Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");
    }
}
