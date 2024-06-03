namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            if (a >= 90)
            {
                Console.WriteLine($"{a} means you get 'A'.");
            }
            else
            {
                if (a >= 80 && a < 90)
                {
                    Console.WriteLine($"{a} means you get 'B'.");

                }
                else
                {
                    if (a >= 70 && a < 80)
                    {
                        Console.WriteLine($"{a} means you get 'C'.");
                    }
                    else
                    {
                        if (a >= 60 && a < 70)
                        {
                            Console.WriteLine($"{a} means you get 'D'.");
                        }
                        else
                        {
                            if (a < 60)
                            {
                                Console.WriteLine($"{a} means you get 'F'.");
                            }
                        }
                    }
                }
            }
            
        }
    }
}
