using System;

namespace Prep1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is prep 1");

            Console.Write("what is your first name? ");
            string first_name= Console.ReadLine();

            Console.Write("what is your last name? ");
            string last_name= Console.ReadLine();

            Console.Write($"Your name is {last_name} , {first_name} {last_name}");
        }
    }
}
