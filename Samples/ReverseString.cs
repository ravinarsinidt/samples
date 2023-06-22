using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samples
{
    public class ReverseString
    {
        public static string Reverse(string s)
        {
            // split string in to words 
            string result = string.Empty;
            string[] words = ReverseString.SplitString(s, " ");
            // parse words one by one and revere
            for (int i = 0; i < words.Length; i++)
            {
                string reveredWord = ReverseString.ReverseWord(words[i]);
                // concat reversed words into another string
                result = result + reveredWord;
            }

            // return the reversed string
            return result;
        }

        public static string[] SplitString(string str, string separator)
        {
            string[] arr = new string[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                string temp = "";
                if (str[i] != ' ')
                {
                    temp = temp + str[i];
                }
                else
                {
                    arr[i] = temp;
                }
            }

            return arr;
        }

        public static string ReverseWord(string str)
        {
            string rev = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev = rev + str[i];



            }
            rev = rev + " ";


            return rev;
        }
    }
}
