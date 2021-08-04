using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingBatArray_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] nums2 = { 1 };
            Console.WriteLine(FirstLast6(nums));
            Console.WriteLine(SameFirstLast(nums2));
            Console.WriteLine(MakePi());
            Console.ReadLine();
        }
        public static bool FirstLast6(int[] nums)
        {
            if (nums[0] == 6 || nums[nums.Length - 1] == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool SameFirstLast(int[] nums2) {
            if (nums2.Length != 0 && nums2[0] == nums2[nums2.Length - 1])
            {
                return true;
            }
            else {
                return false;
            }
        }

        public static int[] MakePi() {
            int[] pieValues = { 3, 1, 4 };
            return pieValues;
        }
    }
}
