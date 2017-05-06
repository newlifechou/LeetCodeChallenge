using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LeetCode
{
    public class LeetCodeSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //参考http://www.jiuzhang.com/solutions/two-sum/
            int[] results = { };
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Count(); i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    int[] result = { dic[nums[i]] , i  };
                    return result;
                }
                //leetcode 测试代码有重复数值，所以必须判断一下
                if (dic.ContainsKey(target - nums[i]))
                {
                    continue;
                }
                dic.Add(target - nums[i], i);
            }
            return results;
        }
    }
}
