using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class AlgorithmSolution
    {
        public int BinarySearch(int key, int[] arrays)
        {
            int low = 0;
            int high = arrays.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (key == arrays[mid])
                {
                    return mid;
                }
                else if (key > arrays[mid])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }

            }

            return -1;

        }
    }
}
