using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC414
    {
        public int ThirdMax(int[] nums)
        {
            var linq = nums.Distinct().ToArray();
            Array.Sort(linq);
            if (linq.Length < 3)
            {
                return linq.Max();
            }
            return linq[linq.Length - 3];
        }
    }
}
