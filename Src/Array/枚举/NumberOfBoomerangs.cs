
namespace Alogorihm.Array.枚举
{
    class NumberOfBoomerangs
    {
        public int Solve(int[][] points)
        {
            int ans = 0;
            Dictionary<int, int> map = new();

            foreach (var p1 in points)
            {
                map.Clear();
                foreach (var p2 in points)
                {
                    int d2 = (p1[0] - p2[0]) * (p1[0] - p2[0]) + (p1[1] - p2[1]) * (p1[1] - p2[1]);

                    if (map.ContainsKey(d2))
                    {
                        ans += map[d2] * 2;
                        map[d2]++;
                    }
                    else
                    {
                        map[d2] = 1;
                    }
                    //ans += map[d2]++ * 2;
                }
            }

            return ans;
        }
    }
}