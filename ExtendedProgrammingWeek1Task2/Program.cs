using System;

namespace ExtendedProgrammingWeek1Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal centimetersInAnInch = 2.54M;

            decimal amountOfInches = 3.23M;

            decimal inchesAsCentimeters = amountOfInches * centimetersInAnInch;

            Console.WriteLine($"{amountOfInches} inches is {inchesAsCentimeters} centimeters");

            Console.ReadLine();
        }
    }
}
