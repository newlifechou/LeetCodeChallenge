using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.MST
{
    internal class MST0806
    {
        /// <summary>
        /// 汉诺塔问题
        /// 递归和分治
        /// n=1，直接移动
        /// n=2,借助B，
        /// n>2,可以看成是n=2的情况的，1到n-1看成给一个盘子，n看成给一个盘子
        /// 上n-1从A到B（子问题，递归)
        /// 最大从A到C
        /// 再B的n-1从B到C(子问题，递归)
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        public void Hanota(IList<int> A, IList<int> B, IList<int> C)
        {
            Move(A.Count, A, B, C);
        }

        /// <summary>
        /// 移动n个盘子从A到C
        /// </summary>
        /// <param name="n"></param>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        private void Move(int n, IList<int> A, IList<int> B, IList<int> C)
        {
            //直接将盘子从A移动到C
            if (n == 1)
            {
                C.Insert(0, A[0]);
                A.RemoveAt(0);
                return;
            }

            //移动n-1个盘子从A到B
            Move(n - 1, A, C, B);

            //移动第N个盘子从A到C，数组的最开始一个是最底下
            C.Insert(0, A[0]);
            A.RemoveAt(0);

            //移动n-1个盘子从B到C
            Move(n - 1, B, A, C);
        }

    }
}
