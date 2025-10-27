namespace Alogorihm.Array.不定长滑动窗口
{
    /// <summary>
    /// 统计优美子数组
    /// https://leetcode.cn/problems/count-number-of-nice-subarrays/description/
    /// </summary>
    class NumberOfSubarrays
    {
        public int Slove(int[] nums, int k)
        {
            return Slove2(nums, k) - Slove2(nums, k - 1);
        }

        public int Slove2(int[] nums, int k)
        {
            int left = 0;
            int ans = 0;
            int count = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                count += nums[right] % 2;

                while (count > k)
                {
                    if (nums[left] % 2 == 1)
                    {
                        count--;
                    }
                    left++;
                }

                ans += right - left + 1;
            }
            
            return ans; 
        }
    }
}