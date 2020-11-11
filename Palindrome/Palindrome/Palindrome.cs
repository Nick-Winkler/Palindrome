using System;

namespace Palindrome
{
    public static class PalindromeChecker
    {
        /// <summary>
        /// Returns a boolean value indicating whether the provided string is a palindrome.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPalindrome(string value)
        {
            int lowerIndex = (value.Length / 2) - 1; // Travels downward from center
            int higherIndex; // Travels upward from center

            // The higher index needs to be adjusted depending on the odd/even status of the array size
            if (value.Length % 2 == 1)
            {
                higherIndex = (value.Length / 2) + 1;
            }
            else 
            {
                higherIndex = value.Length / 2;
            }

            int numberOfComparisons = value.Length / 2; // Keeps this calculation out of the loop
            for (var i = 0; i < numberOfComparisons; i++)
            {
                // Ignores the case but doesn't account for different culture types
                if (!Char.ToLower(value[lowerIndex]).Equals(Char.ToLower(value[higherIndex])))
                {
                    return false;
                }

                // Move to the next indexes in both directions
                lowerIndex--;
                higherIndex++;
            }

            return true;
        }
    }
}
