using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 3, 1, 5, 7, 5, 9};
            int target = 10;
            int[] result = TwoSums(list, target);
            Console.WriteLine("[" + list[result[0]] + ", " + list[result[1]] + "]");
            Console.ReadLine();
        }

        public static int[] TwoSums(int[] nums, int target)
        {
            int[] result = new int[2];
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int goal = target - nums[i];
                if (dict.ContainsKey(goal))
                {
                    result[1] = i;
                    result[0] = dict[goal];
                    break;
                }
                else if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            return result;
        }
    }
}
