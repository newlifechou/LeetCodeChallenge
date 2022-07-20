using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 跳跃游戏
    /// 下标为最大跳跃长度
    /// </summary>
    public class LC55
    {
        public bool CanJump(int[] nums)
        {
            //存储每个位置可以到达的最远位置
            int[] jump = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                jump[i] = nums[i] + i;
            }

            int index = 0;
            //存储当前可以到达的最远位置
            int max_jump = jump[0];
            //index达到数组长度或者超过最远位置
            while (index < jump.Length && index <= max_jump)
            {
                if (max_jump < jump[index])
                {
                    max_jump = jump[index];
                }
                index++;
            }

            if (index == jump.Length)
                return true;

            return false;

        }
    }
}
