using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-18
    /// </summary>
    public class FourSumSolution
    {
        /// <summary>
        /// 思路
        /// 类似3 Sum
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            List<IList<int>> result = new List<IList<int>>();

            //特殊情况处理
            if (nums == null | nums.Length < 4)
            {
                return result;
            }

            Array.Sort(nums);
            for (int i = 0; i < nums.Length-3; i++)
            {
                //去掉重复的数字
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                //开始第二个循环，也就是3Sum了
                for (int j = i+1; j < nums.Length-2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                        continue;
                    //双指针开始
                    int left = j + 1;
                    int right = nums.Length - 1;
                    while (left<right)
                    {
                        int sum = nums[i] + nums[j] + nums[left] + nums[right];
                        if (sum == target)
                        {
                            //保存结果
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });

                            //去重，跳过不必要的位置
                            while (left + 1 < right && nums[left + 1] == nums[left])
                            {
                                left++;
                            }
                            while (right - 1 > left && nums[right - 1] == nums[right])
                            {
                                right--;
                            }
                            //去完重复的数字后，left++对应的number肯定变大，那么right肯定要--才行
                            //在和确定，第一个和第二个数字确定的情况下，第三个数字变大，那么第四个数字肯定要变小
                            left++;
                            right--;
                        }
                        else if(sum<target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }



            return result;
        }
    }
}
