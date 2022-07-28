using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC1331
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            //保存排序后
            int[] sorted=new int[arr.Length];
            Array.Copy(arr,0, sorted, 0, arr.Length);
            Array.Sort(sorted);
            //保存各元素序号
            Dictionary<int, int> ranks = new Dictionary<int, int>();

            int[] ans=new int[arr.Length];
            foreach (var item in sorted)
            {
                if (!ranks.ContainsKey(item))
                {
                    ranks.Add(item, ranks.Count + 1);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                ans[i] = ranks[arr[i]];
            }

            return ans;
        }
    }
}
