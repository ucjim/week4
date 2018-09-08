using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool content ;
            int input;
            Random random = new Random();
            int randomNumber = random.Next(0, 9);           
            Console.WriteLine(randomNumber);
            Console.Write("Enter Input : ");
            int.TryParse(Console.ReadLine(), out input);
            bool A = true;
            if (A)
            {
                Console.WriteLine("input={0} random={1}",input, randomNumber);
            }
            Console.ReadKey();
        }
    }
}
