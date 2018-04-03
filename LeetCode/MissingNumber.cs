using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-268
    /// </summary>
    public class MissingNumber
    {
        /// <summary>
        /// 思路
        /// 用大小是n的布尔数组做chechlist
        /// 遍历原数组check，对应数字索引的位置check
        /// 没有check的就是缺失的数字
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MissingNumberPosition1(int[] nums)
        {
            bool[] positions = new bool[nums.Length + 1];
            for (int i = 0; i < positions.Length; i++)
            {
                positions[i] = false;
            }

            foreach (var item in nums)
            {
                positions[item] = true;
            }

            for (int i = 0; i < positions.Length; i++)
            {
                if (!positions[i])
                    return i;
            }
            return -1;
        }
        /// <summary>
        /// 好的算法
        /// 用完整序列的和-原数组的和
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MissingNumberPosition2(int[] nums)
        {
            int n = nums.Length + 1;
            int sum_orignal = nums.Sum();
            //高斯求和，(首项+末项)*项数/2
            //首项=0，末项=n-1,项数=n
            int sum_complete = (n - 1) * n / 2;

            return sum_complete - sum_orignal;
        }
    }
}
