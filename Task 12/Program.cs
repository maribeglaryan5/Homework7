using System.ComponentModel.Design;

namespace Task_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 45;
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else
            {
                if (num == 0)
                {
                    Console.WriteLine($"The number {num} == 0.");
                }
                else
                {
                    Console.WriteLine($"The number {num} is negative.");

                }
            }
            
        }
    }
}
