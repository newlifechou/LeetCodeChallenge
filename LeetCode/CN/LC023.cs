using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{

    public class MyCompare : IComparer<ListNode>
    {
        public int Compare(ListNode x, ListNode y)
        {
            return x.val.CompareTo(y.val);
        }
    }
    public class LC023
    {
        public ListNode MergeKLists3(ListNode[] lists)
        {
            if (lists == null && lists.Length == 0)
                return null;
            SortedList<int, int> sorted = new SortedList<int, int>();
            for (int i = 0; i < lists.Length; i++)
            {
                while (lists[i] != null)
                {
                    if (!sorted.ContainsKey(lists[i].val))
                    {
                        sorted.Add(lists[i].val, 1);
                    }
                    else
                    {
                        sorted[lists[i].val]++;
                    }
                    lists[i] = lists[i].next;
                }
            }

            ListNode dummy = new ListNode(-1);
            ListNode cur = dummy;
            while (sorted.Count != 0)
            {
                int firstKey = sorted.Keys[0];
                ListNode p = new ListNode(firstKey);
                sorted[firstKey]--;
                if (sorted[firstKey] == 0)
                    sorted.RemoveAt(0);
                cur.next = p;
                cur = cur.next;
            }

            cur.next = null;
            return dummy.next;
        }
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null && lists.Length == 0)
                return null;

            SortedList<ListNode, int> queue = new SortedList<ListNode, int>(new MyCompare());

            for (int i = 0; i < lists.Length; i++)
            {
                while (lists[i] != null)
                {
                    if (!queue.ContainsKey(lists[i]))
                    {
                        queue.Add(lists[i], 1);
                    }
                    else
                    {
                        queue[lists[i]]++;
                    }

                    lists[i] = lists[i].next;
                }
            }

            ListNode dummy = new ListNode(-1);
            ListNode p = dummy;
            while (queue.Count != 0)
            {
                ListNode tmp = queue.Keys[0];
                queue[tmp]--;
                if (queue[tmp] == 0)
                    queue.RemoveAt(0);

                p.next = tmp;
                p = p.next;
            }

            p.next = null;
            return dummy.next;
        }

        /// <summary>
        /// 分治合并
        /// </summary>
        /// <param name="lists"></param>
        /// <returns></returns>
        public ListNode MergeKLists2(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
                return null;

            return Help(lists, 0, lists.Length - 1);
        }

        private ListNode Help(ListNode[] lists, int begin, int end)
        {
            if (begin == end)
                return lists[begin];

            int mid = (begin + end) / 2;
            ListNode left = Help(lists, begin, mid);
            ListNode right = Help(lists, mid + 1, end);
            return Merge(left, right);
        }

        private ListNode Merge(ListNode a, ListNode b)
        {
            if (a == null || b == null)
                return a == null ? b : a;
            if (a.val <= b.val)
            {
                a.next = Merge(a.next, b);
                return a;
            }
            else
            {
                b.next = Merge(a, b.next);
                return b;
            }
        }

    }
}
