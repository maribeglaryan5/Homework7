namespace Task_19
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            char symbol = 'a';
            char symbol1 = 'e';
            char symbol2 = 'i';
            char symbol3 = 'o';
            char symbol4 = 'u';
            char symbol5 = 'z';
            switch (symbol)
            {
                case 'a':
                    Console.WriteLine("'a' is vowel.");
                    break;
                case 'e':
                    Console.WriteLine("'e' is vowel.");
                    break;
                case 'i':
                    Console.WriteLine("'i' is vowel.");
                    break;
                case 'o':
                    Console.WriteLine("'o' is vowel.");
                    break;
                case 'u':
                    Console.WriteLine("'u' is a vowel.");
                    break;
                case 'z':
                    Console.WriteLine("'z' is a consonant");
                    break;
                default:
                    Console.WriteLine("Not recognised char");
                    break;
            }
        }
    }
}
