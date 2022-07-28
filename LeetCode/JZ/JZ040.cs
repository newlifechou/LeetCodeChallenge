using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.JZ
{
    internal class JZ040
    {
        public int[] GetLeastNumbers(int[] arr, int k)
        {
            int[] ans=new int[k];
            Array.Sort(arr);
            for (int i = 0; i < k; i++)
            {
                ans[i] = arr[i];
            }
            return ans;
        }
    }
}
