using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC1413
    {
        /// <summary>
        /// 贪心
        /// 只要保证累加和的最小值即可
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinStartValue1(int[] nums)
        {
            int accSum = 0, accSumMin = 0;
            foreach (var num in nums)
            {
                accSum += num;
                accSumMin = Math.Min(accSumMin, accSum);
            }
            return -accSumMin + 1;
        }

        public int MinStartValue2(int[] nums)
        {
            int n = nums.Min();
            if (n >= 0)
                return 1;

            int left = 1, right = -n * nums.Length + 1;
            while (left < right)
            {
                int medium = (left + right) / 2;
                if (Valid(medium, nums))
                {
                    right = medium;
                }
                else
                {
                    left = medium + 1;
                }
            }
            return left;
        }

        private bool Valid(int startValue, int[] nums)
        {
            foreach (var num in nums)
            {
                startValue += num;
                if (startValue <= 0)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
