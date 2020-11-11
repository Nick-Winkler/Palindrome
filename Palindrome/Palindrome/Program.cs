using System;

namespace Palindrome
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter a string of alphanumeric characters and press enter:\n");

            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input.Equals(""))
                {
                    Console.WriteLine("No characters were found in the previous string. Please enter a string of one or more characters.");
                }
                else
                {
                    break;
                }
            }

            if (PalindromeChecker.IsPalindrome(input))
            {
                Console.WriteLine("The string you entered is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string you entered is not a palindrome.");
            }

            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
        }
    }
}
