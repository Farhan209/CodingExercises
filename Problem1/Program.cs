using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysCount = 0;
            int highestDays = 0;
            int[] salesArray = new int[] {1,2,1,1,0,0,3,1,0,0,2,4,1,0,0,0,0,2,1,0,3,1,0,0,0,6,1,3,0,0,0};
            foreach (int day in salesArray) {
                if (day == 0)
                {
                    daysCount++;
                }
                else {
                    if (daysCount > highestDays)
                    {
                        highestDays = daysCount;
                    }
                    daysCount = 0;
                }
            }
            Console.WriteLine(highestDays);
            Console.ReadLine();
        }
    }
}
