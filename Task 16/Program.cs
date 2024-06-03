namespace Task_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2622;
            int y = 2775;
            int z = 8364;
            int w = 4730;

            if (x < y)
            {
                if (x < z)
                {
                    if (x < w)
                    {
                        Console.WriteLine("The smallest number is " + x);
                    }
                }
            }
            if (y < x)
            {
                if (y < z)
                {
                    if (y < w)
                    {
                        Console.WriteLine("The smallest number is " + y);
                    }
                }
            }
            if (z < w)
            {
                if (z < x)
                {
                    if (z < y)
                    {
                        Console.WriteLine("The smallest number is " + z);
                    }
                }
            }
            if (w < x)
            {
                if (w < y)
                {
                    if (w < z)
                    {
                        Console.WriteLine("The smallest number is" + w);
                    }
                }
            }
        }
    }
}
