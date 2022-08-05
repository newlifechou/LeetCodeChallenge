using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC480
    {
        public double[] MedianSlidingWindow(int[] nums, int k)
        {
            double[] res = new double[nums.Length - k + 1];
            int[] window = new int[k];
            for (int i = 0; i < k; i++)
            {
                window[i] = nums[i];
            }
            Array.Sort(window);
            res[0] = GetMid(window);

            //window slide
            for (int i = 0; i < nums.Length-k; i++)
            {
                //需要删除的数
                int index = Search(window, nums[i]);

                //替换为需要插入的数
                window[index] = nums[i + k];

                //向后冒泡
                while (index < window.Length - 1 && window[index] > window[index+1])
                {
                    Swap(window, index, index + 1);
                    index++;
                }

                //像前冒泡
                while (index > 0 && window[index] < window[index-1])
                {
                    Swap(window, index, index - 1);
                    index--;
                }

                res[i + 1] = GetMid(window);
            }

            return res;
        }

        private void Swap(int[] window, int i, int j)
        {
            int temp = window[i];
            window[i] = window[j];
            window[j] = temp;
        }

        private double GetMid(int[] window)
        {
            int len = window.Length;
            if (len % 2 == 0)
            {
                //避免溢出
                return window[len / 2] / 2.0 + window[len / 2 - 1] / 2.0;
            }
            else
            {
                return window[len / 2];
            }
        }

        private int Search(int[] window, int target)
        {
            int start = 0;
            int end = window.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (window[mid] > target)
                {
                    end = mid - 1;
                }
                else if (window[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }



    }
}
