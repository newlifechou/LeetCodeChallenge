using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC974
    {
        /// <summary>
        /// 和可被k整除的子数组，连续非空
        /// 取余数sum%k
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SubarraysDivByK(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[0] = 1;

            int count = 0;
            int sum = 0;
            int div = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                div = ((sum % k) + k) % k;//考虑负数情况
                if (dict.ContainsKey(div))
                {
                    count += dict[div];
                }
                else
                {
                    dict[div] = 0;
                }
                dict[div]++;
            }

            return count;
        }


        //利用前缀和的思想，p[i] = A[0] + A[1] + … + A[i], 则每个连续子数组的和sum(i, j)
        //就可以写成 p(j) - p(i-1),判断子数组能否被k整除 相当于判断(p(j) - p(i-1) % k == 0 ？

        //(用p(i) 表示数组中0到i数字的总和，如果p(j)与p(i)对k取余得到的结果是相同的， 也就是p(j) -p(i) = nK(n>0 )，那么表示数组 i 到 j 的元素能构成一个这样的子数组)

        //根据同余定理(p(j) - p(i-1) mod k == 0 等价于 p(j) mod k == p(i-1) mod k

        //然后对数组进行遍历，在遍历同时统计答案。当我们遍历到第 i 个元素时，统计以 i 结尾的符合条件的子数组个数。我们可以维护一个以前缀和模 k 的值为键，出现次数为值的哈希表map，在遍历的同时进行更新。这样在计算以 i 结尾的符合条件的子数组个数时，答案即为map[p(i)mod k]

        //最后的答案即为以每一个位置为数尾的符合条件的子数组个数之和。需要注意的一个边界条件是，我们需要对哈希表初始化map[0] = 1，这样就考虑了前缀和本身被 k 整除的情况。

    }
}
