namespace Alogorihm.Array.不定长滑动窗口
{
    /// <summary>
    /// 209. 长度最小的子数组
    /// https://leetcode.cn/problems/minimum-size-subarray-sum/
    /// </summary>
    class MinSubArrayLen
    {
        public int Solve(int target, int[] nums)
        {
            int ans = int.MaxValue;
            int left = 0;
            int sum = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (sum >= target)
                {
                    ans = System.Math.Min(ans, right - left + 1);
                    sum -= nums[left];
                    left++;
                }
            }
            
            return ans == int.MaxValue ? 0 : ans;
        }
    }
}