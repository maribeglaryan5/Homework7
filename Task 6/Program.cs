namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Pause";
            switch(str1)
            {
                case "Start":
                    Console.WriteLine($"Message is Start.");
                    break;
                case "Stop":
                    Console.WriteLine($"Message is Stop");
                    break;
                case "Resume":
                    Console.WriteLine($"Message is Resume.");
                    break;
                case "Pause":
                    Console.WriteLine($"Message is Pause.");
                    break;
                default:
                    Console.WriteLine("There are no appropriate command.");
                    break;
            }
        }
    }
}
