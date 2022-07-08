using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 三数之和
    /// </summary>
    public class LC015
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (nums == null && nums.Length < 3)
                return list;
            //排序，简化操作
            Array.Sort(nums);

            if (nums[0] > 0)
                return list;

            for (int i = 0; i < nums.Length - 2; i++)
            {
                //第一个大于零，肯定不成立
                if (nums[i] > 0)
                    break;

                //如果相邻数相等时，跳过该数，避免重复结果
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;

                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    if (nums[j] + nums[k] + nums[i] == 0)
                    {
                        IList<int> tmp = new List<int>();
                        tmp.Add(nums[i]);
                        tmp.Add(nums[j]);
                        tmp.Add(nums[k]);
                        list.Add(tmp);

                        j++;
                        k--;
                        while (j < k && nums[j] == nums[j - 1])
                        {
                            j++;
                        }

                        while (j < k && nums[k] == nums[k + 1])
                        {
                            k--;
                        }
                    }
                    else if (nums[j] + nums[k] + nums[i] < 0)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }


            }


            return list;
        }
    }
}
