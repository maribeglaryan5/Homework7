using System.Timers;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 35;
            bool haslicence = true;
            if (age >= 18)
            {
                if (haslicence)
                {
                    Console.WriteLine("Joe can drive.");
                }
                else
                {
                    Console.WriteLine("Joe is adult but can't drive.");
                }
            }
            else
            {
                Console.WriteLine("Joe isn't adult.");
            }

        }
    }
}
