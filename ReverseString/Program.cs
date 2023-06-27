using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            string[] mywords = Split(input);
            string revstring = ReverseEachWord(mywords);
            Console.WriteLine("[" + revstring.Trim() + "]");
        }

        private static string ReverseEachWord(string[] mywords)
        {
            string reversedString = string.Empty;
            for(int i = 0; i < mywords.Length; i++)
            {
                string word = mywords[i];
                reversedString = reversedString + ReverseWord(word);
            }

            return reversedString;
        }

        private static string ReverseWord(string word)
        {
            string rstring = string.Empty;
            for (int i = word.Length -1; i >= 0; i--)
            {
                rstring = rstring + word[i];
            }

            return rstring + " ";
        }

        private static string[] Split(string input)
        {
            int noOfWords = GetNumberOfWords(input);
            string[] mywords = new string[noOfWords];
            string word = string.Empty;
            int wordCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    word = word + input[i];
                }
                else
                {
                    mywords[wordCount] = word;
                    wordCount++;
                    word = string.Empty;
                }
            }
            mywords[wordCount] = word;
            return mywords;
        }

        private static int GetNumberOfWords(string input)
        {
            int spaces = 0;
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaces++;
                }
            }
            return spaces + 1;
        }
    }
}
