using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 移除元素
    /// </summary>
    public class LC027
    {


        /// <summary>
        /// 双指针
        /// right要处理的元素，left赋值的位置
        /// right不等于val，copy，left++;right++
        /// right=val，right++
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement(int[] nums, int val)
        {
            int l = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] != val)
                {
                    nums[l] = nums[r];
                    l++;
                }
            }

            return l;
        }

        /// <summary>
        /// 改写为While写法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement2(int[] nums, int val)
        {
            int n = nums.Length;
            int l = 0, r = 0;
            while (l < n && r < n)
            {
                if (nums[r] != val)
                {
                    nums[l] = nums[r];
                    l++;
                    r++;
                }
                else
                {
                    r++;
                }
            }
            return l;
        }


        /// <summary>
        /// 双指针优化
        /// 依然使用双指针，两个指针初始时分别位于数组的首尾，向中间移动遍历该序列
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public int RemoveElement3(int[] nums, int val)
        {
            int l = 0, r = nums.Length;
            while (l < r)
            {
                if (nums[l] == val)
                {
                    nums[l] = nums[r - 1];
                    r--;
                }
                else
                {
                    l++;
                }
            }
            return l;
        }

    }
}
