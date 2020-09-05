using System;

namespace ExtendedProgrammingWeek1Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal centimetersInAnInch = 2.54M;

            bool? parsed = false;

            do
            {
                Console.WriteLine("Enter amount of inches that should be converted to centimeters.");

                string amountOfInchesAsString = Console.ReadLine();

                if (decimal.TryParse(amountOfInchesAsString, out decimal amountOfInches))
                {
                    parsed = true;

                    decimal inchesAsCentimeters = amountOfInches * centimetersInAnInch;

                    Console.WriteLine($"{amountOfInches} inches is {inchesAsCentimeters} centimeters");
                }
                else {
                    Console.WriteLine("Incorrect format, try again...");
                }
            }
            while (parsed == false);

            Console.ReadLine();
        }
    }
}
