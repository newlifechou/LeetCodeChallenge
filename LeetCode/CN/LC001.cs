using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class TwoSum
    {

        /// <summary>
        /// 统计和为0的twoSum问题
        /// 暴力方法
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Count(int[] nums)
        {
            int N = nums.Length;
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (nums[i] + nums[j] == 0)
                        cnt++;
                }
            }
            return cnt;
        }

        public int CountFast(int[] nums)
        {
            return 0;
        }




        /// <summary>
        /// 暴力版本
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] Run1(int[] nums, int target)
        {
            int[] results = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        results[0] = i;
                        results[1] = j;
                        break;
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// 暴力版本的多余循环优化
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] Run2(int[] nums, int target)
        {

            int[] results = new int[2];
            bool isFounded = false;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        results[0] = i;
                        results[1] = j;
                        isFounded = true;
                        break;
                    }
                }
                if (isFounded) break;
            }
            return results;

        }


        /// <summary>
        /// 利用字典实现的高效算法
        /// 思路：将另外一个加数作为key存入字典，位置作为value
        /// 建立数值和位置之间的映射关系
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] Run3(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                //得到另外一个加数
                int another = target - nums[i];
                //将数值作为key，位置i作为value
                if (dict.ContainsKey(another))
                {
                    return new int[] { dict[another], i };
                }

                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            return new int[] { -1, -1 };
        }





    }
}
