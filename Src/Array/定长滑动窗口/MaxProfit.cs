namespace Alogorihm.Array
{
    /// <summary>
    /// 按策略买卖股票的最佳时机
    /// https://leetcode.cn/problems/best-time-to-buy-and-sell-stock-using-strategy/?envType=problem-list-v2&envId=smKmHnN4
    /// </summary>
    class MaxProfit
    {
        public long Solve(int[] prices, int[] strategy, int k)
        {
            long profit = 0;
            int n = prices.Length;
            for (int i = 0; i < n; i++)
            {
                profit += prices[i] * strategy[i];
            }
            long maximumProfit = profit;
            long delta = 0;
            for (int i = 0; i < k; i++)
            {
                delta -= prices[i] * strategy[i];
                if (i >= k / 2)
                {
                    delta += prices[i];
                }
            }
            maximumProfit = System.Math.Max(maximumProfit, profit + delta);
            for (int i = k; i < n; i++)
            {
                delta += prices[i - k] * strategy[i - k];
                delta -= prices[i - k / 2];
                delta += prices[i] - prices[i] * strategy[i];
                maximumProfit = System.Math.Max(maximumProfit, profit + delta);
            }
            return maximumProfit;
        }
    }
}