using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-16
    /// </summary>
    public class ThreeSumClosestSolution
    {
        /// <summary>
        /// 思路
        /// 类似three sum的双指针扫数组
        /// 记录相对target的值和对应的和
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int ThreeSumClosest(int[] nums, int target)
        {
            if (nums == null || nums.Length < 3)
                return 0;
            //res=存放最接近的值
            int res = 0;
            //diff存放计算出来的最大的值
            int diff = int.MaxValue;
            Array.Sort(nums);

            for (int i = 0; i < nums.Length-2; i++)
            {
                int temp = target - nums[i];
                int left = i + 1;
                int right = nums.Length - 1;
                while (left<right)
                {
                    int sum = nums[left] + nums[right];

                    //获得相对值
                    int value = Math.Abs(sum - temp);
                    //如果新的相对值比老的相对值还小，则更新相对值存储，更新对应和
                    if (value <= diff)
                    {
                        diff = value;
                        res = nums[i] + nums[left] + nums[right];
                    }

                    if (sum < temp)
                    {
                        left++;
                    }
                    else if (sum > temp)
                    {
                        right--;
                    }
                    else
                    {
                        return target;
                    }
                }
            }
            return res;
        }
    }
}
