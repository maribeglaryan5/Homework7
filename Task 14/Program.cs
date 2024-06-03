namespace Task_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 12;
            if (age <= 13)
            {
                Console.WriteLine("You are child.");
            }
            else if (age >= 14 && age <= 17)
            {
                Console.WriteLine("You are a teen.");
            }
            else if (age >= 18 && age <= 60)
            {
                Console.WriteLine("You're adult.");
            }
            else if (age >= 61 && age <= 100)
            {
                Console.WriteLine("You're senior.");
            }
            else
            {
                Console.WriteLine("Undefined value: " + age);
            }


            //code
        }
    }
}
