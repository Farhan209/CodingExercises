using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(nextPrime(number));
            Console.ReadLine();
        }
        
        public static bool isPrime(int n)
        {
            if (n <= 1)
            { 
                return false; 
            }
            if (n <= 3)
            {
                return true;
            }

            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= n; i = i + 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int nextPrime(int N)
        {
            if (N <= 1)
            {
                return 2;
            }

            int prime = N;
            bool found = false;

            while (!found)
            {
                prime++;
                if (isPrime(prime))
                {
                    found = true;
                }
            }
            return prime;
        }
    }     
}
