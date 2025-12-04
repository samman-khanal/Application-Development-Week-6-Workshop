
public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        Console.WriteLine("Even Numbers:");
        ProcessNumbers(numbers, num => num % 2 == 0);

        Console.WriteLine("\nNumbers that are greater than 10 are:");
        ProcessNumbers(numbers, num => num > 10);
    }

    public static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (var num in numbers)
        {
            if (condition(num))
            {
                Console.WriteLine(num);
            }
        }
    }
}
