namespace Alogorihm.Array
{
    /// <summary>
    /// 重新安排会议得到最多空余时间|
    /// </summary>
    class MaxFreeTime
    {
        public int Solve(int eventTime, int k, int[] startTime, int[] endTime)
        {
            int n = startTime.Length;
            int[] free = new int[n + 1];
            free[0] = startTime[0];// 最左边的空余时间段

            // 中间的空余时间段
            for (int i = 1; i < n; i++)
            {
                free[i] = startTime[i] - endTime[i - 1];
            }
            free[n] = eventTime - endTime[n - 1];// 最右边的空余时间段

            int ans = 0;
            int s = 0;
            for (int i = 0; i <= n; i++)
            {
                s += free[i];

                if (i < k)
                {
                    continue;
                }
                ans = System.Math.Max(ans, s);
                s -= free[i-k];
            }
            return ans;
        }
    }
}