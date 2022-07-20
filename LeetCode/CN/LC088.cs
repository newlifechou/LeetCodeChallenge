using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC088
    {
        /// <summary>
        /// 反向遍历
        /// 
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="m"></param>
        /// <param name="nums2"></param>
        /// <param name="n"></param>
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int len1 = m - 1;
            int len2 = n - 1;
            int len = m + n - 1;
            while (len1 >= 0 && len2 >= 0)
            {
                if (nums1[len1] > nums2[len2])
                {
                    nums1[len] = nums1[len1];
                    len1--;
                    len--;
                }
                else
                {
                    nums1[len] = nums2[len2];
                    len2--;
                    len--;
                }
            }

            Array.Copy(nums2, 0, nums1, 0, len2 + 1);
        }
    }
}
