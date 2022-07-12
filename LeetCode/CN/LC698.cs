using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CN
{
    public class LC698
    {
        /// <summary>
        /// 划分为k个相等的子集
        /// 输入： nums = [4, 3, 2, 3, 5, 2, 1], k = 4
        ///输出： True
        ///说明： 有可能将其分成 4 个子集（5），（1,4），（2,3），（2,3）等于总和。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public bool CanPartitionKSubsets(int[] nums, int k)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            //直接排除不能划分的情况,剪枝
            if (sum % k != 0)
            {
                return false;
            }

            int avg = sum / k;//每组和

            Array.Sort(nums);

            //最大元素大于sum/k
            if (nums[nums.Length - 1] > avg)
            {
                return false;
            }

            int[] arr = new int[k];

            
            for (int i = 0; i < k; i++)
            {
                arr[i] = avg;
            }

            return Help(nums, nums.Length - 1, arr, k);
        }

        private bool Help(int[] nums, int cur, int[] arr, int k)
        {
            if (cur < 0)
                return true;

            for (int i = 0; i < k; i++)
            {
                //如果正好是当前的数，或者放下当前数之后还有机会放前面的数
                if (arr[i] == nums[cur] || arr[i] - nums[cur] >= nums[0])
                {
                    //放入
                    arr[i] -= nums[cur];
                    //继续放下一个
                    if (Help(nums, cur - 1, arr, k))
                    {
                        return true;
                    }
                    //拿回
                    arr[i] += nums[cur];
                }
            }

            return false;
        }



    }
}
