using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    /// <summary>
    /// 合并两个有序链表
    /// </summary>
    public class LC021
    {
        /// <summary>
        /// Iteration迭代法
        /// 
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists1(ListNode list1, ListNode list2)
        {
            ListNode preHead = new ListNode(-1);
            ListNode prev = preHead;
            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    prev.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    prev.next = list2;
                    list2 = list2.next;
                }
                prev = prev.next;
            }

            //合并完后，最多只有一个还没有被合并，
            prev.next = list1 == null ? list2 : list1;

            return preHead.next;
        }

        /// <summary>
        /// Recursion递归法
        /// list1[0]+merge(list[1:].list2],list1[0] < list2[0]
        /// list2[0]+merge(list1,list2[1:])
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public ListNode MergeTwoLists2(ListNode list1, ListNode list2)
        {
            if (list1 == null)
                return list2;
            else if (list2 == null)
                return list1;
            else if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists2(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists2(list1, list2.next);
                return list2;
            }
        }




    }
}
