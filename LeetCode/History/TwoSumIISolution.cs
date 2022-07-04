using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-167
    /// </summary>
    public class TwoSumIISolution
    {
        /*
         * 返回值index1必须小于index2，且从1开始算基数
         */

        /// <summary>
        /// 思路
        /// 从有序数组的头尾暴力扫描
        /// 但是利用二分法大幅减少不必要的扫描次数
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            int start = 0;
            int end = numbers.Length - 1;
            //开始从头尾扫描
            while (start + 1 < end)
            {

                int mid = start + (end - start) / 2;

                //确定是要右移start，还是左移end
                if (numbers[start] + numbers[end] < target)
                {
                    //进一步确定是否直接右移start到mid，还是一点点移动
                    if (numbers[mid] + numbers[end] < target)
                    {
                        start = mid;
                    }
                    else
                    {
                        start++;
                    }
                }
                else if (numbers[start] + numbers[end] > target)
                {
                    //确定是否直接左移end到mid，还是一点点移动
                    if (numbers[start] + numbers[mid] > target)
                    {
                        end = mid;
                    }
                    else
                    {
                        end--;
                    }
                }
                else
                {
                    break;
                }
            }
            //注意，从1开始，不是从0开始
            result[0] = start + 1;
            result[1] = end + 1;
            return result;
        }
    }
}
