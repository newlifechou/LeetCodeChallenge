using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC004
    {
        /// <summary>
        /// 暴力思路是合并然后找中位数，O(m+n)
        /// 不需要真正合并，只需要找到中位数位置就可以了
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;

            int len = m + n;

            //当前和前一个
            int left = -1, right = -1;
            int start1 = 0, start2 = 0;
            for (int i = 0; i <= len / 2; i++)
            {
                left = right;
                if (start1 < m && (start2 >= n || nums1[start1] < nums2[start2]))
                {
                    right = nums1[start1];
                    start1++;
                }
                else
                {
                    right = nums2[start2];
                    start2++;
                }
            }

            if (len % 2 == 0)
            {
                return (left + right) / 2.0;
            }
            else
            {
                return right;
            }
        }

        /// <summary>
        /// 求第k小数的思路，一半一半排除
        /// 
        /// 看不懂，暂放，以后再说
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public double FindMedianSortedArrays2(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;
            int m = nums2.Length;
            int totalLen = m + n;

            if (totalLen % 2 == 0)
            {
                int midIndex = totalLen / 2;
                double median = GetKth(nums1, nums2, midIndex + 1);
                return median;
            }
            else
            {
                //最中间和前一个数的和一半
                int midIndex1 = totalLen / 2 - 1, midIndex2 = totalLen / 2;
                double median = (GetKth(nums1, nums2, midIndex1 + 1) +
                    GetKth(nums1, nums2, midIndex2 + 1)) / 2.0;
                return median;
            }
        }

        private int GetKth(int[] nums1, int[] nums2, int k)
        {
            int l1 = nums1.Length;
            int l2 = nums2.Length;
            int index1 = 0, index2 = 0;
            int kthElement = 0;
            while (true)
            {
                //boarder
                if (index1 == l1)
                {
                    return nums2[index2 + k - 1];
                }
                if(index2== l2)
                {
                    return nums1[index1 + k - 1];
                }

                if (k == 1)
                {
                    return Math.Min(nums1[index1], nums2[index2]);
                }

                //normal
                int half = k / 2;
                int newIndex1 = Math.Min(index1 + half, l1) - 1;
                int newIndex2 = Math.Min(index2 + half, l2) - 1;

                int pivot1 = nums1[newIndex1];
                int pivot2 = nums2[newIndex2];

                if (pivot1 <= pivot2)
                {
                    k -= (newIndex1 - index1 + 1);
                    index1 = newIndex1 + 1;
                }
                else
                {
                    k -= (newIndex2 - index2 + 1);
                    index2 = newIndex2 + 1;
                }

            }

        }


    }
}
