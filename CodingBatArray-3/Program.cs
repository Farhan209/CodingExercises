using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatArray_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 4, 2, 1, 4, 4, 4 };
            Console.WriteLine(MaxSpan(nums));
            Console.ReadLine();
        }
        public static int MaxSpan(int[] nums)
        {
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int j = nums.Length - 1;

                while (nums[i] != nums[j])
                {
                    j--;
                }

                int span = j - i + 1;

                if (span > max)
                {
                    max = span;
                }
            }
            return max;
        }
    }
}
