using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC509
    {
        /// <summary>
        /// 斐波那契数列
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fib_Recursion(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
        }


        private Dictionary<int,int> map=new Dictionary<int,int>();
        /// <summary>
        /// 使用记忆化操作，将递归返回值保存在全局变量中，后续直接查找
        /// 相当于做了一个redis内存缓存
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int Fib(int n)
        {
            if (n <= 1)
                return n;
            if (map.ContainsKey(n))
                return map[n];

            int result = Fib(n - 1) + Fib(n - 2);
            map[n] = result;

            return result;
        }

    }
}
