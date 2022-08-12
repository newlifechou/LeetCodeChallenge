using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    internal class LC1282
    {
        public IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            //所有组大小相同的下标放在一起
            Dictionary<int, IList<int>> groups = new Dictionary<int, IList<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                int size = groupSizes[i];
                IList<int> list;
                if (groups.ContainsKey(size))
                {
                    list = groups[size];
                }
                else
                {
                    list = new List<int>();
                }
                list.Add(i);
                groups[size] = list;
            }

            IList<IList<int>> result = new List<IList<int>>();
            foreach (var key in groups.Keys)
            {
                IList<int> list = groups[key];
                IList<int> cur = new List<int>();
                for (int i = 0; i < list.Count; i++)
                {
                    cur.Add(list[i]);
                    if (cur.Count == key)
                    {
                        result.Add(cur);
                        cur = new List<int>();
                    }
                }

            }

            return result;


        }
    }
}
