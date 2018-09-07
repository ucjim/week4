using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Hello";

            char ch;

            Console.Write("Press a key followed by ENTER:");

            ch = Console.Read();  // get a char 

            Console.WriteLine("Your key is: " + ch);
            Console.ReadKey();
        }
    }
}
