using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatArray_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] nums2 = { 1,4, 10};
            int[] nums3 = { -10, -4, -2, -4, -2, 0 };
            Console.WriteLine(CountEvens(nums));
            Console.WriteLine(BigDiff(nums2));
            Console.WriteLine(CenteredAverage(nums3));
            Console.ReadLine();
        }

        public static int CountEvens(int[] nums) {
            int count = 0;
            foreach (var num in nums) {
                if (num % 2 == 0) {
                    count++;
                }
            }
            return count;
        }

        public static int BigDiff(int[] nums2) {
            if (nums2.Length == 0) {
                return 0;
            }
            int max = nums2.Max();
            int min = nums2.Min();
            return max - min;
        }

        public static int CenteredAverage(int[] nums3) {
            int sum = 0;
            int result = 0;
            bool maxCounter = false;
            bool minCounter = false;
            foreach (var num in nums3) {
                if (num == nums3.Max() && maxCounter == false)
                {
                    maxCounter = true;
                } else if (num == nums3.Min() && minCounter == false){
                    minCounter = true;
                }
                else {
                    sum += num;
                }
            }
            result = sum / (nums3.Length - 2);
            return result;
        }
    }
}
