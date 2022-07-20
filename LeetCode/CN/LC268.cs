using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 消失的数字
    /// </summary>
    public class LC268
    {
        /// <summary>
        /// 等差数列
        /// 求和后差
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MissingNumber1(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            int add = (1 + nums.Length) * nums.Length / 2;
            return add - sum;
        }

        /// <summary>
        /// 位运算
        /// 出现两次，异或运算，相同位结果为0，不同为1
        /// 丢失数字只出现一次
        /// x^a^a=x
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MissingNumber2(int[] nums)
        {
            int xor = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                xor ^= nums[i];
            }

            for (int i = 1; i < nums.Length + 1; i++)
            {
                xor ^= i;
            }
            return xor;
        }

        /// <summary>
        ///排序
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MissingNumber3(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i)
                    return i;
            }
            return nums.Length;
        }


        /// <summary>
        /// hashset
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MissingNumber4(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                set.Add(nums[i]);
            }
            int missing = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.Contains(i))
                {
                    missing = i;
                    break;
                }
            }
            return missing;
        }



    }
}
