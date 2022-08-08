using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC237
    {
        public void DeleteNode(ListNode node)
        {
            //把要删除节点的值改为下一个节点的值，再把下一个节点删除
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
