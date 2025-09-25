using System.Runtime.InteropServices.Marshalling;

namespace Alogorihm.Array
{
    /// <summary>
    /// 可获得的最大点数
    /// 将问题转换为：计算n-k的连续子数组和的最小值
    /// </summary>
    class MaxScore
    {
        // public int Solve1(int[] cardPoints, int k)
        // {
        //     int ans = 0;

        //     // 如果总牌数等于要拿的数量，则全部拿
        //     if (cardPoints.Length == k)
        //     {
        //         foreach (var score in cardPoints)
        //         {
        //             ans += score;
        //         }

        //         return ans;
        //     }

        //     int leftScore = 0;
        //     int rightScore = 0;

        //     //拿左边的牌
        //     for (int i = 0; i < k; i++)
        //     {
        //         leftScore += cardPoints[i];
        //     }

        //     // 拿右边的牌
        //     for (int i = cardPoints.Length - 1; i > cardPoints.Length - k - 1; i--)
        //     {
        //         rightScore += cardPoints[i];
        //     }

        //     //如果左右的牌点数相等，一起拿
        //     if (leftScore == rightScore)
        //     {
        //         return leftScore + rightScore;
        //     }
        //     else if (leftScore > rightScore)
        //     {
        //         return leftScore;
        //     }
        //     else if (leftScore < rightScore)
        //     {
        //         return rightScore;
        //     }

        //     return 0;

        //     //return ans = leftScore > rightScore ? leftScore : rightScore;
        // }

        // 逆向思维
        public int Solve2(int[] cardPoints, int k)
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