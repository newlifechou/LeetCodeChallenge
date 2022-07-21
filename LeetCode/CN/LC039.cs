using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC039
    {
        /// <summary>
        /// 寻找所有解的题可以考虑回溯
        /// </summary>
        /// <param name="candidates"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> ans = new List<IList<int>>();
            List<int> combine = new List<int>();

            Dfs(candidates, target, 0, ans, combine);
            return ans;
        }

        private void Dfs(int[] candidates, int target,
                            int idx, List<IList<int>> result, List<int> combine)
        {
            if (idx == candidates.Length)
                return;

            if (target == 0)
            {
                result.Add(new List<int>(combine));
                return;
            }

            Dfs(candidates, target, idx + 1, result, combine);

            if (target - candidates[idx] >= 0)
            {
                combine.Add(candidates[idx]);
                Dfs(candidates, target - candidates[idx], idx, result, combine);
                combine.RemoveAt(combine.Count - 1);
            }
        }

    }
}
