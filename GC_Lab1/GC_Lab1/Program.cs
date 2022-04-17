using System;

namespace GC_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            
            var inputInt = 0;

            Console.WriteLine("Hello, " + name + "! Please enter an integer between 1 and 100.");
            var input = Console.ReadLine();

            while (!int.TryParse(input, out inputInt) || inputInt <= 0 || inputInt > 100)
            {
                Console.WriteLine("Incorrect input, " + name + ".");
                Console.WriteLine("Please enter an integer between 1 and 100.");
                input = Console.ReadLine();
            }

            Console.WriteLine("Thank you, " + name + ". " + $"You said {inputInt}!");

            if (inputInt%2 == 0)
            {
                Console.WriteLine("Even.");
            }
            else
            {
                Console.WriteLine("Odd.");        
            }
        }
    }
}
