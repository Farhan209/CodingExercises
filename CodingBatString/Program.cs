using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HelloName("World"));
            Console.WriteLine(MakeAbba("Hi", "Bye"));
            Console.WriteLine(MakeTags("cite", "Yay"));
            Console.ReadLine();
        }

        public static string HelloName(string name)
        {
            return "Hello " + name + "!";
        }

        public static string MakeAbba(string a, string b)
        {
            return a + b + b + a;       
        }

        public static string MakeTags(string tag, string word) {
            return $"<{tag}>{word}</{tag}>";
        }
    }
}
