using System.Numerics;
using System.Runtime.InteropServices;

namespace Alogorihm.Array
{
    /// <summary>
    /// 长度为K子数组中的最大和 
    /// </summary>
    class MaximumSubarraySum
    {
        public long Solve(int[] nums, int k)
        {
            long ans = 0;
            long sum = 0;
            Dictionary<int, int> numMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // 1.维护窗口和和新增哈希表
                sum += nums[i];

                if (numMap.ContainsKey(nums[i]))
                {
                    numMap[nums[i]]++;
                }
                else
                {
                    numMap[nums[i]] = 1;
                }

                int left = i - k + 1;
                if (left < 0)
                {
                    continue;
                }

                // 怎么排除重复元素的数组的元素和？
                if (numMap.Keys.Count == k)
                {
                    //continue;
                    ans = System.Math.Max(ans, sum);
                }

                // 2.更新ans和sum
                sum -= nums[left];
                numMap[nums[left]]--;
                if (numMap[nums[left]] == 0)
                {
                    numMap.Remove(nums[left]);
                }
            }
            return ans;
        }
    }
}