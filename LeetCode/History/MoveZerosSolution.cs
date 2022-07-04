using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-283
    /// </summary>
    public class MoveZerosSolution
    {
        //特别要求
        //不能使用复制数组，必须在本数组内完成
        //操作要最小化

        /// <summary>
        /// 思路
        /// 对数组进行遍历
        /// 对零进行计数
        /// 从发现第一个0开始，对下一位不是0的数字移位，移位距离由计数决定
        /// 后续的数字变为0
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes1(int[] nums)
        {
            int zeroCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCount++;
                }
                else
                {
                    nums[i - zeroCount] = nums[i];
                }
            }

            for (int i = nums.Length - zeroCount; i < nums.Length; i++)
            {
                nums[i] = 0;
            }


        }


        /// <summary>
        /// 有点像快速排序
        /// 非零区和零区
        /// 未知区的第一个非零元素和0区的第一个位置交换，或者是0不管
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes2(int[] nums)
        {
            int firstZero;

            firstZero = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0 && firstZero != i)
                {
                    int temp = nums[firstZero];
                    nums[firstZero] = nums[i];
                    nums[i] = temp;
                    firstZero++;
                }
            }


        }



    }
}
