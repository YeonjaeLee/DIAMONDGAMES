using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_TwoSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] number = new int[4] { 2, 7, 11, 15 };
            int target = 9;
            int[] ans;

            ans = twoSum(number, target);

            Console.Write("[{0}, {1}]\n", ans[0], ans[1]);
        }

        // 1.
        public static int[] twoSum(int[] nums, int target)
        {
            for(int i = 0; i<nums.Length; i++)
            {
                for(int j = i+1; j<nums.Length; j++)
                {
                    if(nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception();
        }
    }
}
