using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-1
    /// </summary>
    public class TwoSumSolution
    {
        /// <summary>
        /// 思路
        /// 暴力不可取
        /// 利用词典
        /// 存入，与当前值匹配的差值key和当前值的位置value
        /// 随后找到这个差值的时候，也就是找到最终的结果
        /// nums[right]=target-nums[left]
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null || nums.Length < 2)
            {
                return null;
            }

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                //找到之前保存的某个left的right了
                if (dict.ContainsKey(nums[i]))
                {
                    int[] indexResult = new int[2];
                    //之前存的left的index
                    indexResult[0] = dict[nums[i]];
                    //current，也就是right的index
                    indexResult[1] = i;
                    return indexResult;
                }
                else
                {
                    //存差值和当前值的索引到dict
                    int right = target - nums[i];
                    //防止添加key相同的
                    if (!dict.ContainsKey(right))
                    {
                        dict.Add(right, i);
                    }
                }
            }

            return null;
        }
    }
}
