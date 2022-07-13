using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC560
    {
        /// <summary>
        /// 暴力方法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SubarraySum1(int[] nums, int k)
        {
            int count = 0, n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                int sumK = 0;
                for (int j = i; j < n; j++)
                {
                    sumK += nums[j];
                    if (sumK == k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }






        /// <summary>
        /// 和为K的子数组
        /// 找出连续的子数组个数
        /// 利用dictionary存储子序列和，
        /// 数组前缀和
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int SubarraySum(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict[0] = 1;

            int sum = 0, count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (dict.ContainsKey(sum - k))
                {
                    count += dict[sum - k];
                }

                if (!dict.ContainsKey(sum))
                {
                    dict[sum] = 0;
                }

                dict[sum]++;
            }


            return count;

        }


        //公式(1)：num[i]+num[i + 1]+…+num[j - 1]+num[j] = k;(i<=j)
        //公式(2)：Ni = num[0]+num[1]+…+num[i]
        //公式(3)：k=num[i]+num[i + 1]+…+num[j - 1]+num[j] = Nj-Ni-1

        //此时我们利用上面提到的前缀数组的思想就可以得出，当i到j的子数组满足公式(3)的要求时，这个子数组就是一个和为k的子数组。也就是说我们在解题时只需要求出每个元素的前缀和，然后就可以在后面利用前缀和的差进行数组个数计算。这样似乎已经优化了解题，但是一计算复杂度发现并没有被优化。
        //我们再回到题目本身，我们会发现，我们关心的其实并不是前缀和之差是不是等于k，我们求这个只是为了计算有多少个前缀和为k的子数组，换句话说我们关心的是在j之前满足Ni ==Nj- k的有多少个。这样我们就很容易想到一种数据结构——map。这样题解终于呼之欲出了（以下两个要点）：

        //遍历 nums 数组，求每一项的前缀和，统计对应的出现次数，以键值对存入 map。
        //边存边查看 map，如果 map 中存在 key 为当前前缀和Nj - k，说明这个之前出现的前缀和，满足Nj - Ni == k，将它出现的次数，累加给 count。
        //注意遍历 nums 之前，考虑到第一个元素就满足条件的状态，我们假设数组下标 -1 对应的前缀和为 0。即在遍历之前，map 初始放入 0:1 键值对（前缀和为0出现1次了）。


    }
}
