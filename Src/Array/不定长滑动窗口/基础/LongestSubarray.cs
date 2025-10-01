namespace Alogorihm.Array
{
    /// <summary>
    /// 删掉一个元素以后全为1的最长子数组
    /// </summary>
    class LongestSubarray
    {
        public int Solve(int[] nums)
        {
            int ans = 0;
            int cnt0 = 0;
            int left = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                cnt0 += nums[right] == 0 ? 1 : 0;
                // 另外一种写法
                //cnt0 += 1 - nums[right];

                while (cnt0 > 1)
                {
                    cnt0 -= nums[left] == 0 ? 1 : 0;
                    // 另外一种写法
                    //cnt0 -= 1 - nums[left];
                    left++;
                }

                ans = System.Math.Max(ans,right - left);
            }
            return ans;
        }
    }
}