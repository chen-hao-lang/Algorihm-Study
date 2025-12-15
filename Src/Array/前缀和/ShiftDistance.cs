namespace Alogorihm.Array.前缀和
{
    /// <summary>
    /// 两个字符串的切换距离
    /// https://leetcode.cn/problems/shift-distance-between-two-strings/description/
    /// </summary>
    class ShiftDistance
    {
        public long Solve(string s, string t, int[] nextCost, int[] previousCost)
        {
            char[] charS = s.ToCharArray();
            char[] charT = t.ToCharArray();

            const int SIGMA = 26;
            long[] nextSUm = new long[SIGMA * 2 + 1];
            long[] preSum = new long[SIGMA * 2 + 1];

            for (int i = 0; i < SIGMA * 2 ; i++)
            {
                nextSUm[i + 1] = nextSUm[i] + nextCost[i % SIGMA];
                preSum[i + 1] = preSum[i] + previousCost[i % SIGMA];
            }

            long ans = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int x = charS[i] - 'a';
                int y = charT[i] - 'a';
                ans += System.Math.Min(nextSUm[x < y ? y : y + SIGMA] - nextSUm[x],
                                preSum[(x < y ? x + SIGMA : x) + 1] - preSum[y + 1]);

            }
            return ans;
        }
    }
}