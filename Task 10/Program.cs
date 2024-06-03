namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1233;
            int b = 3958;
            int c = 1039;

            if (a > b)
            {
                if(a > c)
                {
                    Console.WriteLine("Biggest value is " + a);
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    Console.WriteLine("Biggest value is " + b);
                }
            }
            if(c > a)
            {
                if (c > b)
                {
                    Console.WriteLine("Biggest value is " + c);
                }
            }
        }
    }
}