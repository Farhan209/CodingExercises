using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLowerGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value = random.Next(1, 100);
            int guess = 0;
            int tries = 0;
            bool correct = false;
            
            Console.WriteLine("Guess a Number Between 1 and 100");

            while (!correct)
            {
                Console.Write("Guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                tries++;
                if (guess < value)
                {
                    Console.WriteLine("The Number is Higher Than " + guess);
                }
                else if (guess > value)
                {
                    Console.WriteLine("The Number is Lower Than " + guess);
                }
                else
                {
                    correct = true;
                    Console.WriteLine("You Guessed The Number Correctly in " + tries + " tries");
                    Console.ReadLine();
                }
                if (tries > 50)
                {
                    Console.WriteLine("You Ran Out of Maximum Tries. The number was " + value);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
