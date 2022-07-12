using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC713
    {
        /// <summary>
        /// 乘积小于K的子数组
        /// 双游标，滑动窗口
        /// 维护一个窗口[l,r],并记录该窗口内数组的乘积mut的值
        ///如果该窗口内的数组的乘积为mut小于k,先记录以nums[r] 结尾的子数组个数(r-l+1 为了节约资源可以在窗口扩大之后再求这个值),窗口向右扩大r++，并且mut乘nums[r];
        ///如果窗口内的数组乘积mut大于k，窗口向左缩小,先除去nums[l] 的值, 然后再让l++;
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        ///             
        /// 利用滑动窗口法：
        ///1 当k <= 1时，由于数组为正整数数组，明显不存在满足题意的连续子数组，故直接返回结果0。
        ///2 令保存结果的变量res = 0，滑动区间左指针left = 0，保存滑动区间中元素乘积的变量pro为1。
        ///3 令滑动区间右指针right从数组左到右滑动，每滑动1次，让pro乘以新元素。如果此时pro大于等于k，则滑动左指针left,每滑动一次令pro除以nums[left]，得到新的滑动区间的元素乘积，直到pro < k。此时，以right为右边界，以滑动区间中任一元素为左边界的子数组都满足题意。由此可以得到以right为子数组右边界的所有子树组的个数right - left + 1，将改数值累加至结果res。
        ///4 当right滑动到最右端后，res中便累加了以各个元素为子数组右端点时的有效子数组个数。返回res即可。

        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {
            if (k <= 1)
            {
                return 0;
            }

            int result = 0, left = 0, right = 0, target = 1;
            while (right < nums.Length)
            {
                target *= nums[right];
                while (target >= k && left <= right)
                {
                    target /= nums[left];
                    left++;
                }
                //left到right之间的子集有right-left+1个,解释见下文
                result += right - left + 1;
                right++;
            }
            return result;
        }

        //ans += r - l +1;是怎么得来的？

        //对于有n个元素的集合：

        //包含 1 个元素的子集有 n 个
        //包含 2 个连续元素的子集有 n - 1 个
        //...
        //包含 n 个连续元素的子集有 1 个
        //总共有 1 + 2 + 3 +... + n = （n+1）*n/2个连续元素的子集
        //那么对于n-1个元素的集合：共有n* (n-1)/2个连续元素的子集。

        //【【【【   (n+1)*n/2 - n* (n-1)/2 = n/2 * (2)=n 对于n-1个元素的集合，增加第n个元素，则增加的连续元素子集数为n个。   】】】】

        //对于a[l] ... a[r - 1] 的集合，增加第r个元素a[r]，则增加的连续元素子集数为 a[l] ... a[r] 范围内的元素总数即 n = r - l +1个。






    }
}
