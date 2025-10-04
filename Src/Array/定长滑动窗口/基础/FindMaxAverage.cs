namespace Alogorihm.Array
{
    /// <summary>
    /// 子数组最大平均数|
    /// </summary>
    class FindMaxAverage
    {
        public double Solve(int[] nums, int k)
        {
            double sum = 0;
            double ans = double.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                int left = i - k + 1;
                if (left < 0)
                    continue;

                ans = System.Math.Max(ans, sum / k);
                sum -= nums[left];
            }

            return ans;
        }
    }
}