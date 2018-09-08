using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool content ;
            Random random = new Random();
            int randomNumber = random.Next(0, 9);
            int val1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine(randomNumber);
            content = true;
            Console.WriteLine("",content);

            Console.ReadKey();
        }
    }
}
