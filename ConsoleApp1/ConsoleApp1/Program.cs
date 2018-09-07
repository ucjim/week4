using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String name, Lastname; ;
            int ID;
            double GPA;
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Lastname: ");
            Lastname = Console.ReadLine();
            Console.Write("ID Student:");
            int.TryParse(Console.ReadLine(), out ID);
            Console.Write("GPA:");
            double.TryParse(Console.ReadLine(), out GPA);

            Console.WriteLine(" Name: {0}", name);
            Console.WriteLine("Lastname : {0}", Lastname);
            Console.WriteLine("ID Student:", ID);
            Console.WriteLine("GPA: {0}", GPA);

            Console.ReadKey();
        }
    }
}
