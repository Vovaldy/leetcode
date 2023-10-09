using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_Two_Sum
{
    internal class Two_sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[]? answer = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target) { answer[0] = i; answer[1] = j; }
                }
            }
            return answer;
        }
    }
}
