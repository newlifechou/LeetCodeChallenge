using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC228
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            List<string> ranges = new List<string>();
            int i = 0;
            int n = nums.Length;
            while (i < n)
            {
                //找出low和high
                int low = i;
                i++;
                while (i < n && nums[i] - nums[i - 1] == 1)
                {
                    i++;
                }
                int high = i-1;

                StringBuilder sb = new StringBuilder();
                sb.Append(nums[low]);
                if (low < high)
                {
                    sb.Append("->");
                    sb.Append(nums[high]);
                }
                ranges.Add(sb.ToString());
            }
            return ranges;
        }
    }
}
