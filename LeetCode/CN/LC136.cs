using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC136
    {
        /// <summary>
        /// 暴力
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber1(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int j = 0;

                for (j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == nums[i])
                    {
                        break;
                    }
                }

                if (j == nums.Length)
                {
                    return nums[i];
                }
            }
            return -1;
        }

        public int SingleNumber2(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                if (nums[i] != nums[i + 1])
                {
                    return nums[i];
                }
            }

            return nums[nums.Length - 1];
        }


        /// <summary>
        /// Hash
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber3(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    nums[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }


            foreach (var item in dict)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }
            return -1;
        }

        /// <summary>
        /// 位运算
        /// 和自己做异两次异或恢复原样
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber4(int[] nums)
        {
            int ans = 0;
            foreach (var item in nums)
            {
                ans ^= item;
            }
            return ans;
        }
    }
}
