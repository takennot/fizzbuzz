namespace FizzBuzz;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input != null && Int32.TryParse(input, out int value))
            {
                int n = Int32.Parse(input);
                FizzBuzz(n);
            }
            else if (input.Equals("exit"))
            {
                Environment.Exit(0);
            }
        }
    }

    public static void FizzBuzz(int n)
    {
        Console.WriteLine("___________________________");
        for (int i = 0; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("___________________________");
    }
}
