/*
 * Word Methods
 * Pawelski
 * 2/1/2022
 * Read over the code and run the program a few times to determine
 * what the program does and how it works. Once you understand the
 * program, answer the questions on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, letter;
            Console.Write("Enter a word >> ");
            word = Console.ReadLine();
            Console.Write("Enter a letter >> ");
            letter = Console.ReadLine();

            Console.WriteLine("The first letter of the word \"" 
                + word + "\" is \"" + FirstLetter(word) + "\"");
            Console.WriteLine("The last letter of the word \""
                + word + "\" is \"" + LastLetter(word) + "\"");

            if (ContainsLetter(word, letter))
            {
                Console.WriteLine("The word \"" + word 
                    + "\" does contain \"" + letter + "\"");
            }
            else
            {
                Console.WriteLine("The word \"" + word
                    + "\" does not contain \"" + letter + "\"");
            }
        }

        /*
         * The FirstLetter method returns the first letter of the word.
         * word represents the word
         * returns the first letter of the word
         */
        public static string FirstLetter(string word)
        {
            return word.Substring(0, 1);
        }

        /*
         * The LastLetter method returns the last letter of the word.
         * word represents the word
         * returns the last letter of the word
         */
        public static string LastLetter(string word)
        {
            return word.Substring(word.Length - 1, 1);
        }

        /*
         * The ContainsLetter method determines whether a letter is
         * inside a word.
         * word represents the word to search
         * letter represents the letter to search for
         * returns true if the letter is in the word or false if it is not
         */
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
