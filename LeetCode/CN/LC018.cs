using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC018
    {
        /// <summary>
        /// 三数之和的扩展
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);

            IList<IList<int>> res = new List<IList<int>>();

            if (nums.Length < 4)
                return res;

            int len = nums.Length;

            int m = 0, n = 0;
            for (int i = 0; i <= len - 4; i++)
            {
                //跳过重复的nums[i]
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                for (int j = i + 1; j <= len - 3; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1])
                        continue;
                    m = j + 1;
                    n = len - 1;
                    while (m < n)
                    {
                        long sum = 0;
                        try
                        {
                            checked
                            {
                                sum = nums[i] + nums[j] + nums[m] + nums[n];
                            }
                        }
                        catch (Exception)
                        {
                            break;
                        }

                        if ((int)sum < target)
                            m++;
                        else if ((int)sum > target)
                            n--;
                        else
                        {
                            res.Add(new List<int> {
                                nums[i],
                                nums[j],
                                nums[m],
                                nums[n] });
                            while (m < n && nums[m] == nums[m + 1])
                            {
                                m++;
                            }
                            while (m < n && nums[n] == nums[n - 1])
                            {
                                n--;
                            }
                            m++;
                            n--;
                        }
                    }


                }
            }

            return res;
        }
    }
}
