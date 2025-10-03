namespace Alogorihm.Array
{
    /// <summary>
    /// 最大连续1的个数|||
    /// </summary>
    class LongestOnes
    {
        public int Solve(int[] nums, int k)
        {
            // 问题转换，求包含k个0的最长子数组
            int ans = 0;
            int left = 0;
            int currentZeroNum = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                currentZeroNum += nums[right] == 0 ? 1 : 0;

                while (currentZeroNum > k)
                {
                    currentZeroNum -= nums[left] == 0 ? 1 : 0;
                    left++;
                }

                ans = System.Math.Max(ans, right - left + 1);
            }
            return ans;
        }
    }
}