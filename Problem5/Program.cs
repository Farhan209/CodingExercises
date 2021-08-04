using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse("hello world"));
            Console.ReadLine();
        }

        public static string Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reverseString = new string(charArray);
            return reverseString;
        }
    }
}
