using System;

namespace GC_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool go = true;

            while (go == true)
            {
                Console.WriteLine("Please enter your name.");
                string name = Console.ReadLine();

                var inputInt = 0;

                Console.WriteLine();
                Console.WriteLine("Hello, " + name + "! Please enter an integer between 1 and 100.");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out inputInt) || inputInt <= 0 || inputInt > 100)
                {
                    Console.WriteLine("Incorrect input, " + name + ".");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Thank you, {name}.");
                    if (inputInt % 2 == 0)
                    {
                        if (inputInt >= 2 && inputInt > 60)
                        {
                            Console.WriteLine($"{inputInt} is even and greater than 60.");
                        }
                        else
                        {
                            if (inputInt <= 24)
                            {
                                Console.WriteLine($"{inputInt} is even and less than 25.");
                            }
                            else
                            {
                                Console.WriteLine($"{inputInt} is even and between 26 and 60 inclusive.");
                            }
                        }
                    }
                    else
                    {
                        if (inputInt < 60)
                        {
                            Console.WriteLine($"{inputInt} is odd and less than 60.");
                        }
                        else
                        {
                            Console.WriteLine($"{inputInt} is odd and greater than 60.");
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("If you would like to try again, press Y.");
                string goAgain = Console.ReadLine();
                if (goAgain.ToUpper() != "Y")
                {
                    go = false;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Bye!");
        }
    }
}
