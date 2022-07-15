using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 给你一个整数数组 nums ，数组中共有 n 个整数。
    /// 132 模式的子序列 由三个整数 nums[i]、nums[j] 和 nums[k] 组成，
    /// 并同时满足：i < j < k 和 nums[i] < nums[k] < nums[j]
    /// </summary>
    public class LC456
    {
        /// <summary>
        /// 132模式
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public bool Find132pattern(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            int secondMax = int.MinValue;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                while (stack.Count != 0 && nums[i] > stack.Peek())
                {
                    secondMax = stack.Pop();
                }

                if (nums[i] > secondMax)
                    stack.Push(nums[i]);

                if (nums[i] < secondMax)
                    return true;
            }

            return false;
        }
    }
}
