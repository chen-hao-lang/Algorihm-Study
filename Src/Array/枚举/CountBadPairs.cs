using System.Data;
using System.Globalization;

namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 统计坏数对的数目
    /// </summary>
    class CountBadPairs
    {
        public int Solve(int[] nums)
        {
            int ans = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (i < j && j - i != nums[j] - nums[i])
                    {
                        ans++;
                    }
                }
            }

            return ans;
        }

        public long Solve2(int[] nums)
        {
            long n = nums.Length;
            long ans = n * (n - 1) / 2;
            Dictionary<int, int> cnt = new();
            for (int i = 0; i < n; i++)
            {
                int x = nums[i] - i;
                if (cnt.TryGetValue(x, out int value))
                {
                    ans -= value;
                }

                if(cnt.ContainsKey(x))
                {
                    cnt[x]++;
                }
                else
                {
                    cnt.Add(x, 1);
                }
            }

            return ans;
        }
    }
}