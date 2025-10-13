namespace Alogorihm.Array.不定长滑动窗口
{
    /// <summary>
    /// 统计最大元素出现至少K次的子数组数目
    ///https://leetcode.cn/problems/count-subarrays-where-max-element-appears-at-least-k-times/description/    
    /// </summary>
    class CountSubarrays
    {
        public long Slove1(int[] nums, int k)
        {
            int maxValue = nums.Max();
            int left = 0;
            long res = 0;
            int count = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                count += nums[right] == maxValue ? 1 : 0;

                while (count >= k)
                {
                    count -= nums[left] == maxValue ? 1 : 0;
                    left++;
                }

                res += left;
            }

            return res;
        }

        public long Slove2(int[] nums, int k)
        {
            int max = nums.Max();

            long ans = 0;
            int cnt = 0, left = 0;

            foreach (int x in nums)
            {
                if (x == max)
                {
                    cnt++;
                }

                while (cnt == k)
                {
                    if (nums[left] == max)
                    {
                        cnt--;
                    }
                    left++;
                }
                ans += left;
            }

            return ans;
        }
    }
}