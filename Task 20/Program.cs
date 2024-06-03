namespace Task_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 47739;
            int b = 37484;
            int c = 35739;
            int d = 47720;
            int e = 47730;


            if (a > b)
            {
                if (a > c)
                {
                    if (a > d)
                    {
                        if (a > e)
                        {
                            Console.WriteLine($"The largest number is {a}.");
                        }
                    }
                }
            }
            if (b > a)
            {
                if (b > c)
                {
                    if (b > d)
                    {
                        if (b > e)
                        {
                            Console.WriteLine($"The largest number is {b}.");
                        }
                    }
                }
            }
            if (c > a)
            {
                if (c > b)
                {
                    if (c > d)
                    {
                        if (d > e)
                        {
                            Console.WriteLine($"The largest number is {c}.");
                        }
                    }
                }
            }
            if (d > a)
            {
                if (d > b)
                {
                    if (d > c)
                    {
                        if (d > c)
                        {
                            if (d > e)
                            {
                                Console.WriteLine($"The largest number is {d}.");
                            }
                        }
                    }
                }
            }
            if (e > a)
            {
                if (e > b)
                {
                    if (e > c)
                    {
                        if (e > d)
                        {
                            Console.WriteLine($"The largest number is {e}.");
                        }
                    }
                }
            }
        }
    }
}
