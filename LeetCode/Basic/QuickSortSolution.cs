using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Basic
{
    public class QuickSortSolution
    {
        private void Swap(ref int i,ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        private int Partition(int[] nums, int l, int r)
        {
            //选取支点
            int pivot = nums[r];
            //j指向比pivot大的第一个元素，它左边都是比pivot小的
            int i, j;
            i = j = l;

            while (i < r)
            {
                //将小于支点的移动到j的左边
                if (nums[i] < pivot)
                {
                    Swap(ref nums[j], ref nums[i]);
                    j++;
                }
                i++;
            }
            //把pivot交换到j的位置
            Swap(ref nums[j], ref nums[r]);


            return j;
        }

        public void QuickSort(int[] nums, int l, int r)
        {
            if (l < r)
            {
                int m = Partition(nums, l, r);
                //递归
                QuickSort(nums, l, m + 1);
                QuickSort(nums, m, r);
            }
        }
    }
}
