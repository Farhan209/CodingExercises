using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodingBatString_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleChar("Hi-There"));
            //Console.WriteLine(CountHi("hihiabcdhihi"));
            Console.WriteLine(CatDog("1cat1cadodog"));
            Console.ReadLine();
        }

        public static string DoubleChar(string str) {
            string doubleValue = "";
            foreach (char c in str) {
                doubleValue += c;
                doubleValue += c;
            }
            return doubleValue;
        }

        /* public static int CountHi(string str) {
             int count = 0;
             for (int i = 0; i < str.Length - 1; i++) {
                 if (str.Substring(i, i+2) == "h") {
                     count++;
                 };
             }
             return count;
         }*/

        public static bool CatDog(string str) {
            int dogC = 0;
            int catC = 0;
            dogC = Regex.Matches(str, "dog").Count;
            catC = Regex.Matches(str, "cat").Count;
            if (dogC == catC) {
                return true;
            } else {
                return false;
            }
        }
    }
}
