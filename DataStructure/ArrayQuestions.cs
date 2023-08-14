using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructure
{
    public static class ArrayQuestions
    {
        //public static string Sentence = "I have 50 books in my 2 bookshelves";
        public static void Test()
        {
            //var result = CountWords("I have 50 books in my 2 bookshelves");
            var result=IfPalindrome(121);
            Console.WriteLine(result);
            var result2 = IfPalindrome(-121);
            Console.WriteLine(result2);
        }


        /// <summary>
        /// count how many non-number words in a given sentence
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>

        public static int CountWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            int count = 0;
            foreach (string word in words)
            {
                if (!int.TryParse(word, out int thisWord))
                {
                    count++;
                }
            }

            return count;
        }


        //[Leetcode]9. Palindrome Number
        //Given an integer x, return true if x is a palindrome, and false otherwise.
        /*
         * Example 1:

            Input: x = 121
            Output: true
            Explanation: 121 reads as 121 from left to right and from right to left.
            Example 2:

            Input: x = -121
            Output: false
            Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.
         */

        public static bool IfPalindrome(int number) {
            var forwardString = number.ToString();
            var backwardString = forwardString.ToCharArray();  // string to char[]
            Array.Reverse(backwardString);                     // Array reverse -- static
            var backwardString2 = new string(backwardString);  // Instantiate an string with char[]
            return forwardString.Equals(backwardString2);      // Comparison
        }

    }
}