using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// leetcode-2
    /// </summary>
    public class AddTwoNumbersSolution
    {
        /// <summary>
        /// 链表转换成数字，相加后再转换成链表
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
        {

            return null;
        }
        /// <summary>
        /// 直接按照链表的形式进行计算
        /// carry为进位
        /// 使用头指针而不是头结点
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
        {
            ListNode resultHead = null;

            if(l1==null&&l2==null)
            {
                return resultHead;
            }

            int sum = 0, carry = 0;
            ListNode cursor = resultHead;

            while (l1!=null||l2!=null)
            {
                int num1 = l1 == null ? 0 : l1.val;
                int num2 = l2 == null ? 0 : l2.val;
                sum = num1 + num2 + carry;
                cursor.next = new ListNode(sum % 10);
                carry = sum / 10;
                cursor = cursor.next;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;

            }

            if (carry != 0)
            {
                cursor.next = new ListNode(carry);
            }

            return resultHead;
        }
    }
}
