using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 下一个更大元素Ⅰ
    /// nums1 中数字 x 的 下一个更大元素 是指 x 在 nums2 中对应位置 右侧 的 第一个 比 x 大的元素。
    /// </summary>
    internal class LC496
    {
        /// <summary>
        /// 暴力方法思路
        /// 遍历nums1，找出元素在nums2中位置，找出
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] NextGreaterElement1(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];

            for (int i = 0; i < nums1.Length; i++)
            {
                int j = 0;
                while (j < nums2.Length && nums2[j] != nums1[i])
                {
                    j++;
                }
                int k = j + 1;
                while (k < nums2.Length && nums2[k] < nums2[j])
                {
                    k++;
                }
                result[i] = k < nums2.Length ? nums2[k] : -1;
            }

            return result;
        }

        /// <summary>
        /// 单调栈+hash表
        /// 先计算nums2中每个元素右边第一个更大的元素
        /// 存储这些结果
        /// </summary>
        /// <param name="nums1"></param>
        /// <param name="nums2"></param>
        /// <returns></returns>
        public int[] NextGreaterElement2(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            for (int i = nums2.Length - 1; i >= 0; i--)
            {
                int num = nums2[i];
                while (stack.Count > 0 && num >= stack.Peek())
                {
                    stack.Pop();
                }
                dict.Add(num, stack.Count > 0 ? stack.Peek() : -1);
                stack.Push(num);
            }

            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                result[i] = dict[nums1[i]];
            }

            return result;
        }

    }
}
