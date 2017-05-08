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
        //3sum
        public List<List<int>> ThreeSum(int[] nums)
        {
            var results = new List<List<int>>();
            if (nums.Length < 3)
            {
                return results;
            }

            for (int i = 0; i < nums.Length - 2; i++)
            {
                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 2; k < nums.Length; k++)
                    {
                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            results.Add(new List<int> { i, j, k });
                        }
                    }
                }
            }
            return results;
        }
        //https://leetcode.com/problems/longest-substring-without-repeating-characters
        public int LengthOfLongestSubstring(string s)
        {
            //http://www.jiuzhang.com/solutions/longest-substring-without-repeating-characters/
            int[] map = new int[256]; //map from character's ASCII to its last occured index
            int j = 0;
            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                while (j < s.Length && map[s[j]] == 0)
                {
                    map[s[j]] = 1;
                    ans = Math.Max(ans, j - i + 1);
                    j++;
                }
                map[s[i]] = 0;
            }

            return ans;
        }

        //https://leetcode.com/problems/add-two-numbers
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //http://www.jiuzhang.com/solutions/add-two-numbers/
            if (l1 == null & l2 == null)
            {
                return null;
            }

            ListNode head = new ListNode(0);
            ListNode point = head;
            int carry = 0;
            while (l1 != null && l2 != null)
            {
                int sum = carry + l1.val + l2.val;
                point.next = new ListNode(sum % 10);
                carry = sum / 10;
                l1 = l1.next;
                l2 = l2.next;
                point = point.next;
            }

            while (l1 != null)
            {
                int sum = carry + l1.val;
                point.next = new ListNode(sum % 10);
                carry = sum / 10;
                l1 = l1.next;
                point = point.next;
            }
            while (l2 != null)
            {
                int sum = carry + l2.val;
                point.next = new ListNode(sum % 10);
                carry = sum / 10;
                l2 = l2.next;
                point = point.next;
            }
            if (carry != 0)
            {
                point.next = new ListNode(carry);
            }

            return head.next;
        }
        //https://leetcode.com/problems/two-sum
        public int[] TwoSum(int[] nums, int target)
        {
            //参考http://www.jiuzhang.com/solutions/two-sum/
            int[] results = { };
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Count(); i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    int[] result = { dic[nums[i]], i };
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


        public int[] TwoSumSortedInput(int[] nums, int target)
        {
            int[] result = new int[2];
            int start = 0;
            int end = nums.Length - 1;
            while (start + 1 < end)
            {
                int middle = start + (end-start) / 2;
                if (nums[start] + nums[end] < target)
                {
                    if (nums[middle] + nums[end] < target)
                    {
                        start = middle;
                    }
                    else
                    {
                        start++;
                    }
                }
                else if (nums[start] + nums[end] > target)
                {
                    if (nums[start] + nums[middle] > target)
                    {
                        end = middle;
                    }
                    else
                    {
                        end--;
                    }
                }
                else
                {
                    break;
                }

            }
            result[0] = start + 1;
            result[1] = end + 1;
            return result;

        }
    }
}
