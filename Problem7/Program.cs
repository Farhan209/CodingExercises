using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1324;
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
