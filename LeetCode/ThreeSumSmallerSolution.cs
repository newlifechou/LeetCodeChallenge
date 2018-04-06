using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-259
    /// locked
    /// </summary>
    public class ThreeSumSmallerSolution
    {
        /*
        Given an array of n integers nums and a target, find the number of index triplets 
        i, j, k with 0 <= i < j < k < n that satisfy the condition nums[i] + nums[j] + nums[k] < target.
        For example, given nums = [-2, 0, 1, 3], and target = 2.
        Return 2. Because there are two triplets which sums are less than 2:
          [-2, 0, 1] [-2, 0, 3]
        Follow up:
        Could you solve it in O(n2) runtime?
         */

        /// <summary>
        /// 思路
        /// 类似three sum的双指针思路
        /// </summary>
        /// <param name="sums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int ThreeSumSmaller(int[] nums, int target)
        {
            //排序
            Array.Sort(nums);
            int result = 0;
            //右边至少留出2个位置作为two和three
            for (int i = 0; i < nums.Length - 2; i++)
            {
                //one=current or left
                //two=center
                //three=right
                int two = i + 1;
                int three = nums.Length - 1;
                int one = nums[i];

                while (two < three)
                {
                    int temp_sum = nums[two] + nums[three];
                    //如果和满足条件，右移动two
                    if (one + temp_sum < target)
                    {
                        //因为three已经最大了，所以比three小的位置和two相加肯定也是满足的
                        //即three -two个组合都是符合要求的
                        result += three - two;
                        two++;
                    }
                    else //如果和大了，就把three往左边移动一下
                    {
                        three--;
                    }
                }

            }
            return result;
        }


    }
}
