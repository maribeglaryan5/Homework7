using System.Net.Security;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 86;
            int b = 19;
            bool isAOdd = a % 2 != 0;
            bool isBOdd = b % 2 != 0;
            if (isAOdd)
            {
                Console.WriteLine($"{a} is odd");
            }
            else
            {
                Console.WriteLine($"{a} is even");
            }

            if (isBOdd)
            {
                Console.WriteLine($"{b} is odd");
            }
            else
            {
                Console.WriteLine($"{b} is even");
            }
        }
    }
}
