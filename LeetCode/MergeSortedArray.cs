using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Leetcode-88
    /// </summary>
    public class MergeSortedArray
    {
        /*
         * 假设nums1的空闲空间足够大，m+n
         */

        /// <summary>
        /// 思路
        /// 双游标对比插入新数组,
        /// 将长数组剩下的依次添补到新数组结尾
        /// 将新数组每个元素复制到nums1
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] arr = new int[m + n];
            int i = 0, j = 0, k = 0;
            while (i < m && j < n)
            {
                if (nums1[i] < nums2[j])
                {
                    arr[k] = nums1[i];
                    i++;
                }
                else
                {
                    arr[k] = nums2[j];
                    j++;
                }
                k++;
            }

            while (i < m)
            {
                arr[k] = nums1[i];
                i++;
                k++;
            }

            while (j < n)
            {
                arr[k] = nums2[j];
                j++;
                k++;
            }

            for (i = 0; i < m + n; i++)
            {
                nums1[i] = arr[i];
            }


        }
    }
}
