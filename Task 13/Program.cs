namespace Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string grade = "Poor";

            if(grade == "Excellent")
            {
                Console.WriteLine("Excellent");
            }
            else
            {
                if(grade == "Good")
                {
                    Console.WriteLine("Good");
                }
                else
                {
                    if(grade == "Average")
                    {
                        Console.WriteLine("Average");
                    }
                    else
                    {
                        if(grade == "Poor")
                        {
                            Console.WriteLine("Poor");
                        }
                        else
                        {
                            if (grade == "Fail")
                            {
                                Console.WriteLine("Fail");
                            }
                        }
                    }
                }
            }
        }
    }
}
