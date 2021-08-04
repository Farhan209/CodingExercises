using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordOriginal = "star";
            string[] wordsList = { "parts", "traps", "arts", "rats", "starts", "tarts", "rat", "art", "tar", "tars", "stars", "stray" };

            char[] wordChar = wordOriginal.ToLower().ToCharArray();
            Array.Sort(wordChar);
            string wordSorted = new string(wordChar);

            foreach (string value in wordsList) {
                char[] compareChar = value.ToLower().ToCharArray();
                Array.Sort(compareChar);
                string compareWord = new string(compareChar);

                if (wordSorted == compareWord)
                {
                    Console.WriteLine("The word '" + value + "' is an anagram");
                }
            }
            Console.ReadLine();
        }
    }
}
