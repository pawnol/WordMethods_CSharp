using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMethods
{
    class WordHelper
    {
        /*
         * The FirstLetter method returns the first letter of the word.
         * word represents the word
         * returns the first letter of the word
         */
        public static string FirstLetter(string word)
        {
            return word.Substring(0, 1);
        }

        public static bool ContainsLetter(string word, string letter)
        {
            for(int i = 0; i < word.Length; i++)
            {
                if (word.Substring(i, 1) == letter)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
