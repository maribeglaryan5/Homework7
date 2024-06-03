namespace Task_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            int b = 20;
            int c = 30;

            if (a == b && b == c)
            {
                Console.WriteLine("Triangle is equilateral");
            }
            else if(a == b || b == c || c == a)
            {
                Console.WriteLine("Triangle is isosceles");
            }
            else
            {
                Console.WriteLine("Triangle is scalene");
            }
        }
    }
}

