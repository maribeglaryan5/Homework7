using System.Net.Http.Headers;

namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuOption2 = 3;
            switch (menuOption2)
            {
                case 1:
                    Console.WriteLine("Start game.");
                    break;
                case 2:
                    Console.WriteLine("Load game");
                    break;
                case 3:
                    Console.WriteLine("Exit.");
                    break;
                default:
                    Console.WriteLine("Invalid action.");
                    break;
            }
        }
    }
}
