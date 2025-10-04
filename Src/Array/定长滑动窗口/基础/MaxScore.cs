using System.Globalization;
using System.Runtime.InteropServices.Marshalling;

namespace Alogorihm.Array
{
    /// <summary>
    /// 可获得的最大点数
    /// 将问题转换为：计算n-k的连续子数组和的最小值
    /// </summary>
    class MaxScore
    {
        // 逆向思维
        public int Solve1(int[] cardPoints, int k)
        {
            //int ans = 0;
            int n = cardPoints.Length;
            int m = n - k;
            int s = 0;

            for (int i = 0; i < m; i++)
            {
                s += cardPoints[i];
            }

            int total = s;
            int minS = s;

            for (int i = m; i < n; i++)
            {
                total += cardPoints[i];
                s += cardPoints[i] - cardPoints[i - m];
                minS = System.Math.Min(minS, s);
            }

            return total - minS;
        }
    }
}