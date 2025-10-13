namespace Alogorihm.Array.定长滑动窗口
{
    class MinimumDifference
    {
        public int Solve(int[] nums, int k)
        {
            int ans = int.MaxValue;
            System.Array.Sort(nums);

            for (int right = 0; right < nums.Length; right++)
            {
                int left = right - k + 1;
                if (left < 0)
                {
                    continue;
                }

                ans = System.Math.Min(ans, nums[right] - nums[left]);
            }

            return ans;
        }
    }
}