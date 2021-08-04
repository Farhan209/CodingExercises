using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNumbers = new ArrayList();
            int ct = 0;
            int n = 0;
            int i = 1;
            int j = 1;

            while (n < 25)
            {
                j = 1;
                ct = 0;
                while (j <= i)
                {
                    if (i % j == 0)
                    {
                        ct++;
                    }
                    j++;
                }
                if (ct == 2)
                {
                    primeNumbers.Add(i);
                    n++;
                }
                i++;
            }

            int position = 20;
            Console.WriteLine(primeNumbers[position - 1]);
            Console.ReadLine();
        }
    }
}
