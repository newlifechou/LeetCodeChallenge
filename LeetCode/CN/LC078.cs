using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC078
    {
        /// <summary>
        /// 子集
        /// 返回所有可能的子集，不重复，包含空
        /// 暴力迭代
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> Subsets_Violent(int[] nums)
        {
            List<IList<int>> result = new List<IList<int>>();
            //先加一个空集进去
            result.Add(new List<int>());
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                List<IList<int>> newList = new List<IList<int>>();
                foreach (var item in result)
                {
                    List<int> newSubset = new List<int>(item);
                    newSubset.Add(nums[i]);
                    newList.Add(newSubset);
                }
                result.AddRange(newList);
            }

            return result;
        }

        /// <summary>
        /// 回溯，递归
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> Subsets(int[] nums)
        {
            result = new List<IList<int>>();
            if (nums.Length == 0)
                return result;

            var tempList = new LinkedList<int>();
            dfs(nums, 0, tempList);

            return result;
        }

        private List<IList<int>> result;

        private void dfs(int[] nums,int start,LinkedList<int> list)
        {
            result.Add(new List<int>(list));
            for (int i = start; i < nums.Length; i++)
            {
                list.AddLast(nums[i]);
                dfs(nums, i + 1, list);
                list.RemoveLast();
            }
        }

    }
}
