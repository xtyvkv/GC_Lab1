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

            if (!int.TryParse(input, out inputInt) || inputInt <= 0 || inputInt > 100)
            {
                Console.WriteLine("Incorrect input, " + name + ".");
                Console.WriteLine("Please enter an integer between 1 and 100.");
                /* figure out how to restart cuz your previous idea flopped HARD */
            }
            else
            {
                if (inputInt % 2 == 0)
                {
                    if (inputInt >= 2 && inputInt > 60)
                    {
                        Console.WriteLine("Thank you, " + name + ". " + $"You said {inputInt}, which is even and greater than 60.");
                    }
                    else
                    {
                        if (inputInt <= 24)
                        {
                            Console.WriteLine("Thank you, " + name + ". " + $"You said {inputInt}, which is even and less than 25.");
                        }
                        else
                        {
                            Console.WriteLine("Thank you, " + name + ". " + $"You said {inputInt}, which is even and between 26 and 60 inclusive.");
                        }
                    }
                }
                else
                {
                    if (inputInt < 60)
                    {
                        Console.WriteLine("Thank you, " + name + ". " + $"You said {inputInt}, which is odd and less than 60.");
                    }
                    else
                    {
                    Console.WriteLine("Thank you, " + name + ". " + $"You said {inputInt}, which is odd and greater than 60.");
                    }
                }

                /* figure this out too. extra credit baby!!!
                
                Console.WriteLine("Go again?");

                */
            }
        }
    }
}
