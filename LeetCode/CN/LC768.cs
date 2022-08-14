using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC768
    {
        /// <summary>
        /// 记录两组频次之差，为0时候，则表示有一个新块
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public int MaxChunksToSorted(int[] arr)
        {
            Dictionary<int, int> cnt = new Dictionary<int, int>();
            int res = 0;
            int[] sortedArr = new int[arr.Length];
            Array.Copy(arr, sortedArr, arr.Length);
            Array.Sort(sortedArr);
            for (int i = 0; i < sortedArr.Length; i++)
            {
                int x = arr[i];
                int y = sortedArr[i];

                if (!cnt.ContainsKey(x))
                {
                    cnt.Add(x, 0);
                }

                cnt[x]++;

                if (cnt[x] == 0)
                {
                    cnt.Remove(x);
                }

                if (!cnt.ContainsKey(y))
                {
                    cnt.Add(y, 0);
                }

                cnt[y]--;

                if (cnt[y] == 0)
                {
                    cnt.Remove(y);
                }

                if (cnt.Count == 0)
                {
                    res++;
                }

            }

            return res;
        }
    }
}
