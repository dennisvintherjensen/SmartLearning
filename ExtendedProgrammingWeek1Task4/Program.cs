using System;

namespace ExtendedProgrammingWeek1Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive whole number to FizzBuzz - and Jazz");

            int n = PromptAmount();

            for (int i = 1; i <= n; i++)
            {
                string output = String.Empty;

                if (i % 3 == 0)
                {
                    output += "Fizz";
                }

                if (i % 5 == 0)
                {
                    output += "Buzz";
                }

                if (i % 7 == 0)
                {
                    output += "Jazz";
                }

                Console.WriteLine(string.IsNullOrEmpty(output) ? i.ToString() : output);
            }
        }

        static int PromptAmount()
        {
            if (int.TryParse(Console.ReadLine(), out int amount))
            {
                return amount;
            }
            else
            {
                Console.WriteLine("Incorrect format, try again...");

                return PromptAmount();
            }
        }
    }
}
