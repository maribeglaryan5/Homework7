namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = 30;
            bool isRaining = true;
            
            if (isRaining == false && temperature > 20)
            {
                Console.WriteLine("Good weather for a walk");
            }
            else
            {
                Console.WriteLine("Stay indoors");
            }
        }
    }
}
