
using System.Diagnostics.Contracts;

namespace Alogorihm.Array
{
    class MaxSum
    {
        public long Solve(IList<int> nums, int m, int k)
        {
            long ans = 0, sum = 0;
            Dictionary<int, int> count = new Dictionary<int, int>();

            for (int i = 0; i < nums.Count; i++)
            {
                // 将当前元素加入窗口
                sum += nums[i];
                if (count.ContainsKey(nums[i]))
                {
                    count[nums[i]]++;
                }
                else
                {
                    count[nums[i]] = 1;
                }

                int left = i - k + 1;
                if (left < 0)
                { // 窗口大小不足k，继续添加元素
                    continue;
                }

                // 当窗口中不同元素的数量满足要求时，更新答案
                if (count.Count >= m)
                {
                    ans = System.Math.Max(ans, sum);
                }

                // 移除窗口最左侧的元素
                int outVal = nums[left];
                sum -= outVal;
                count[outVal]--;
                if (count[outVal] == 0)
                {
                    count.Remove(outVal);
                }
            }

            return ans;
        }
    }
}