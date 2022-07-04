using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-15
    /// </summary>
    public class ThreeSumSolution
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            //为了避免后面的转换，也可以声明
            List<IList<int>> result = new List<IList<int>>();
            //List<List<int>> result = new List<List<int>>();
            //对nums排序
            Array.Sort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                int one = nums[i];
                //重复的数字跳过
                if (i > 0 && one == nums[i - 1])
                {
                    continue;
                }

                int two = i + 1;
                int three = nums.Length - 1;
                while (two<three)
                {
                    int sub_sum = nums[two] + nums[three];
                    //one肯定是负数
                    //判断后两个数字的和是否大于one的绝对值
                    //大于，则two+three位置的数字的和小了，two需要往右
                    if (sub_sum < -1 * one)
                    {
                        two++;
                    }
                    else if(sub_sum>-1*one)
                    {
                        three--;
                    }
                    else
                    {
                        //记录下这个Ok的
                        List<int> list = new List<int>();
                        list.Add(one);
                        list.Add(nums[two]);
                        list.Add(nums[three]);

                        result.Add(list);

                        //跳过重复数字，特别是0
                        while (two+1<three&&nums[two]==nums[two+1])
                        {
                            two++;
                        }

                        while (three-1>two&&nums[three]==nums[three-1])
                        {

                            three--;
                        }

                        two++;
                        three--;
                    }

                }

            }
            //这里必须这么转换
            //参见https://www.zhihu.com/question/56554741
            //return (IList<IList<int>>)result.Select(r => r).ToList<IList<int>>() ;
            return result;
        }
    }
}
