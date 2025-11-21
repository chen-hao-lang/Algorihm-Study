namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 买卖股票的最好时机
    /// https://leetcode.cn/problems/best-time-to-buy-and-sell-stock/
    /// </summary>
    class MaxProfit
    {
        public int Solve1(int[] prices)
        {
            int ans=  0;
            int minPrices=  prices[0];

            foreach(int p in prices)
            {
                ans = System.Math.Max(ans,p - minPrices);
                minPrices = System.Math.Min(minPrices,p);
            }
            return ans;
        }
    }
}