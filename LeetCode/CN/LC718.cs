using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC718
    {
        /// <summary>
        /// 最长重复子数组
        /// 暴力方法
        /// 枚举A的起始位置i和B的起始位置j，计算最长的公共前缀k
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int FindLength1(int[] nums1, int[] nums2)
        {
            int ans = 0;
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    int k = 0;
                    while (i + k < nums1.Length && j + k < nums2.Length && nums1[i + k] == nums2[j + k])
                    {
                        k++;
                    }

                    ans = Math.Max(ans, k);
                }
            }

            return ans;
        }
        public int FindLength2(int[] nums1, int[] nums2)
        {
            int[,] dp = new int[nums1.Length + 1, nums2.Length + 1];
            int ans = 0;
            for (int i = 1; i <= nums1.Length; i++)
            {
                for (int j = 1; j <= nums2.Length; j++)
                {
                    if (nums1[i - 1] == nums2[j - 1])
                    {
                        dp[i, j] = dp[i - 1, j - 1] + 1;
                    }
                    ans = Math.Max(ans, dp[i, j]);
                }
            }
            return ans;
        }
        public int FindLength3(int[] nums1, int[] nums2)
        {
            return 0;
        }
        public int FindLength4(int[] nums1, int[] nums2)
        {
            return 0;
        }
        //1.暴力法，找枚举A[i:],B[j:]，2个n， 然后找公共前缀又一个n.总共n立方，超时无法完成。

        //2.动态规划，也是遍历A[i:],B[j:]，用map优化了公共前缀，共n2,6000+ ms

        //3.滑动窗口，没有优化公共前缀，而是尝试以对齐字符来优化了遍历字串的过程，也是n2级别, 4000 ms

        //4.二分法+哈希查找 nlogn级别，164 ms Amazing !!!
    }
}
