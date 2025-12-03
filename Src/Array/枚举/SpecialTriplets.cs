namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 统计特殊三元组
    /// https://leetcode.cn/problems/count-special-triplets/description/
    /// </summary>
    public class SpecialTriplets
    {
        private const int mod = 1000000007;
        public int Solve(int[] nums)
        {
            long ans = 0;
            Dictionary<int, int> map = new();

            foreach (var num in nums)
            {
                if (map.ContainsKey(num))
                {
                    map[num]++;
                }
                else
                {
                    map[num] = 1;
                }
            }

            Dictionary<int, int> pre = new();
            foreach (int x in nums)
            {
                map[x]--;

                int target = x * 2;
                int leftCount = pre.ContainsKey(target) ? pre[target] : 0;
                int rightCount = pre.ContainsKey(target) ? map[target] : 0;

                ans += (long)leftCount * rightCount;

                if (pre.ContainsKey(x))
                {
                    pre[x]++;
                }
                else
                {
                    pre[x] = 1;
                }
            }

            return (int)(ans % mod);
        }

        public int Solve2(int[] nums)
        {
            Dictionary<int, int> leftCounts = new Dictionary<int, int>();
            Dictionary<int, int> rightCounts = new Dictionary<int, int>();
            int n = nums.Length;

            int[] leftSpecial = new int[n];
            int[] rightSpecial = new int[n];

            for (int i = 0; i < n; i++)
            {
                leftSpecial[i] = leftCounts.ContainsKey(nums[i] * 2) ? leftCounts[nums[i] * 2] : 0;
                leftCounts.TryAdd(nums[i], 0);
                leftCounts[nums[i]]++;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                rightSpecial[i] = rightCounts.ContainsKey(nums[i] * 2) ? rightCounts[nums[i] * 2] : 0;
                rightCounts.TryAdd(nums[i], 0);
                rightCounts[nums[i]]++;
            }

            int specialCount = 0;
            for (int i = 1; i < n - 1; i++)
            {
                int currSpecialCount = (int)((long) leftSpecial[i] * rightSpecial[i] % mod);
                specialCount = (specialCount + currSpecialCount) % mod;
            }

            return specialCount;
        }
    }
}