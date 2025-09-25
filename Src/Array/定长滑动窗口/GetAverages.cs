namespace Alogorihm.Array
{
    /// <summary>
    /// 半径为K的子数组平均值
    /// </summary>
    class GetAverages
    {
        public int[] Solve(int[] nums, int k)
        {
            int[] avgs = new int[nums.Length];
            System.Array.Fill(avgs,-1);

            double sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                // 1.进入窗口
                sum += nums[i];

                // 窗口大小不足2K+1
                if (i < k * 2)
                {
                    continue;
                }

                // 2.记录答案
                avgs[i - k] = (int)sum / (2 * k + 1);
                // 3.离开窗口
                sum -= nums[i - k * 2];
            }
            return avgs;
        }
    }
}