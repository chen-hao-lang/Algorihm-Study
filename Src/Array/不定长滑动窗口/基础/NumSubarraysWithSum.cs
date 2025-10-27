namespace Alogorihm.Array.不定长滑动窗口
{
    /// <summary>
    /// 和相同的二元子数组
    /// https://leetcode.cn/problems/binary-subarrays-with-sum/description/
    /// </summary>
    class NumSubarraysWithSum
    {
        public int Slove(int[] nums, int goal)
        {
            return AtMost(nums, goal) - AtMost(nums, goal - 1);
        }

        private int AtMost(int[] nums, int goal)
        {
            if (goal < 0) return 0;

            int left = 0;
            int ans = 0;
            int count = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                count += nums[right];

                while (count > goal)
                {
                    count -= nums[left];
                    left++;
                }

                ans += right - left + 1;
            }

            return ans;
        }
    }
}