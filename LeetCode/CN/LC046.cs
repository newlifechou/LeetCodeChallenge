using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC046
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> ans = new List<IList<int>>();
            int[] visited = new int[nums.Length];

            BackTrack(ans,nums,new List<int>(),visited);
            return ans;
        }

        private void BackTrack(List<IList<int>> ans, int[] nums,
            List<int> output,int[] visited)
        {
            if (output.Count == nums.Length)
            {
                ans.Add(new List<int>(output));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (visited[i] == 1)
                    continue;
                visited[i] = 1;
                output.Add(nums[i]);
                BackTrack(ans, nums, output, visited);
                visited[i] = 0;
                output.RemoveAt(output.Count - 1);
            }

        }



    }
}
