using System;
using Xunit;

namespace Palindrome.Tests
{
    public class PalindromeTests
    {
        [Fact]
        public void ShouldReturnTrueIfPalindrome()
        {
            var simplePal = "mom";
            var mixedCharPal = "Hannah";
            var numericPal = "5005";
            var longPal = GetLongPalindrome(); // This is the reason I couldn't make this test a Theory

            Assert.True(PalindromeChecker.IsPalindrome(simplePal));
            Assert.True(PalindromeChecker.IsPalindrome(mixedCharPal));
            Assert.True(PalindromeChecker.IsPalindrome(numericPal));
            // Tests the speed to make sure it runs fast without getting really slow on the big stuff
            Assert.True(PalindromeChecker.IsPalindrome(longPal));
        }

        [Fact]
        public void ShouldReturnFalseIfNotPalindrome()
        {
            var notAPal = "dog";

            Assert.False(PalindromeChecker.IsPalindrome(notAPal));
        }

        private string GetLongPalindrome()
        {
            // Alphanumeric-only to make this simpler, but it should work for all characters
            var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

            var arraySize = 1000000; // Needs to be an even number for this test to work as-is
            var arrayMiddleIndex = arraySize / 2;
            var randomizedCharArray = new char[arraySize];

            var rand = new Random();

            // Stop at the middle of the array to allow for mirroring it
            for (var i = 0 ; i < arrayMiddleIndex; i++)
            {
                var currentChar = chars[rand.Next(0, chars.Length - 1)];
                randomizedCharArray[i] = currentChar;
                // (arraysize - 1) to account for index starting at 0
                randomizedCharArray[(arraySize - 1) - i] = currentChar;
            }

            return new string(randomizedCharArray);
        }
    }
}
