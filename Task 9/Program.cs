namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int selectedLevel = 2;
            switch (selectedLevel)
            {
                case 1:
                    Console.WriteLine("The level is beginner.");
                    break;
                case 2:
                    Console.WriteLine("The level is intermediate.");
                    break;
                case 3:
                    Console.WriteLine("The level is advanced.");
                    break;
                default:
                    Console.WriteLine("Invalid level.");
                    break;
            }
        }
    }
}
