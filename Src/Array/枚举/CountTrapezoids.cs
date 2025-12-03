using System.Net.Http.Headers;

namespace Alogorihm.Array.枚举
{
    class CountTrapezoids
    {
        private const int mod = 1000000007;
        public int Solve(int[][] points)
        {
            //int ans = 0;
            Dictionary<int, int> map = new();
            // 先存储同一条边上的点数
            foreach (var poin in points)
            {
                int y = poin[1];
                if (map.ContainsKey(y))
                {
                    map[y]++;
                }
                else
                {
                    map[y] = 1;
                }
            }

            long ans = 0;
            long s = 0;
            foreach (var c in map.Values)
            {
                // 当前边能组多少条
                long k = (long)c * (c - 1) / 2;
                ans += s * k;
                s += k;
            }
            return (int)(ans % mod);
        }
    }
}