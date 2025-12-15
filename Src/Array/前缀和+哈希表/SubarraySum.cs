namespace Alogorihm.Array.前缀和哈希表
{
    /// <summary>
    /// 和为K的子数组
    /// https://leetcode.cn/problems/subarray-sum-equals-k/
    /// </summary>
    class SubarraySum
    {
        public int Solve2(int[] nums, int k)
        {
            int n = nums.Length;
            int[] preSumArray = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                preSumArray[i + 1] = preSumArray[i] + nums[i];
            }

            int ans = 0;
            Dictionary<int, int> cnt = new Dictionary<int, int>(n + 1);
            foreach (var sum in preSumArray)
            {
                int target = sum - k;
                if(cnt.TryGetValue(target,out int count))
                {
                    ans += count;
                }

                if(cnt.ContainsKey(sum))
                {
                    cnt[sum]++;
                }
                else
                {
                    cnt[sum] = 1;
                }
            }

            return ans;
        }
    }
}