﻿namespace Task_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int e = 5;
            switch (e)
            {
                case 1:
                    Console.WriteLine($"Option 1 selected.");
                    break;
                case 2:
                    Console.WriteLine($"Option 2 selected.");
                    break;
                case 3:
                    Console.WriteLine($"Option 3 selected.");
                    break;
                case 4:
                    Console.WriteLine($"Option 4 seleceted");
                    break;
                case 5:
                    Console.WriteLine($"Option 5 selected.");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
