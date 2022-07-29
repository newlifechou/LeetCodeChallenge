using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC141
    {
        /// <summary>
        /// hashtable
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle1(ListNode head)
        {
            HashSet<ListNode> cycle = new HashSet<ListNode>();
            while (head!=null)
            {
                if (!cycle.Add(head))
                {
                    return true;
                }
                head = head.next;
            }
            return false;
        }

        /// <summary>
        /// fast slow pointer
        /// 龟兔赛跑
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public bool HasCycle2(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }

            ListNode turtle = head;
            ListNode rabbit = head.next;
            while (turtle!=rabbit)
            {
                if (rabbit == null || rabbit.next == null)
                {
                    return false;
                }
                turtle = turtle.next;
                rabbit = rabbit.next.next;
            }
            return true;
        }
    }
}
