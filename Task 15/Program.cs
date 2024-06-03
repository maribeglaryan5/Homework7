namespace Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = 4;
            int d = 3;
            if (a > b && a > c && a > d)
            {
                Console.WriteLine($"The max number is {a}.");
            }
            if (b > a && b > c && b > d)
            {
                Console.WriteLine($"The max number is {b}.");
            }
            if (c > a && c > b && c > d)
            {
                Console.WriteLine($"The max number is {c}.");
            }
            if (d > a && d > b && d > c)
            {
                Console.WriteLine($"The max number is {d}.");
            }
        }
    }
}