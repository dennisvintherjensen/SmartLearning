using System;
using System.Text.RegularExpressions;

namespace ExtendedProgrammingWeek1Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text for palindrome test.");

            string input = PromptInput();

            string cleanedInput = CleanAndLowercaseInput(input);

            if (IsPalindrome(cleanedInput))
            {
                Console.WriteLine($@"""{input}"" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{input} is NOT a palindrome.");
            }

            Console.WriteLine("Press any key to exit");

            Console.ReadLine();
        }

        static bool IsPalindrome(string input)
        {
            int midSentence = (int)decimal.Round(input.Length / 2);

            for (int i = 0; i <= input.Length; i++)
            {
                if (i > midSentence)
                {
                    break;
                }

                char left = input[i];

                char right = input[input.Length - 1 - i];

                if (left != right)
                {
                    return false;
                }
            }

            return true;
        }

        static string CleanAndLowercaseInput(string input)
        {
            return Regex.Replace(input, "[^a-z0-9]", "", RegexOptions.IgnoreCase).ToLower();
        } 

        static string PromptInput()
        {
            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("You need to input some text. try again...");

                return PromptInput();
            }
        }
    }
}
