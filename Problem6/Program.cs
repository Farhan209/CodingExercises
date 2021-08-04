using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "step on no pets";
            CheckPalindrome(word);
            Console.ReadLine();
        }

        public static void CheckPalindrome(string word)
        {
            char[] charList = word.ToCharArray();
            Array.Reverse(charList);
            string reverse = new string(charList);

            if (word.Equals(reverse))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
