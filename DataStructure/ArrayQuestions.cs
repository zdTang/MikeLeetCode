namespace DataStructure
{
    public static class ArrayQuestions
    {
        //public static string Sentence = "I have 50 books in my 2 bookshelves";
        public static void Test()
        {
            var result = CountWords("I have 50 books in my 2 bookshelves");
            Console.WriteLine(result);
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
    }
}