namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayOfTheWeek = 1;
            switch (dayOfTheWeek)
            {
                case 1:
                    Console.WriteLine("Monday.");
                    break;
                case 2:
                    Console.WriteLine("Tuesday.");
                    break;
                case 3:
                    Console.WriteLine("Wednesday.");
                    break;
                case 4:
                    Console.WriteLine("Thursday.");
                    break;
                case 5:
                    Console.WriteLine("Friday.");
                    break;
                case 6:
                    Console.WriteLine("Saturday.");
                    break;
                default:
                    Console.WriteLine("Set value is out of 1-7.");
                    break;
                    


            }
        }
    }
}
