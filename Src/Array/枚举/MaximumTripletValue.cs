namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 有序三元组中的最大值||
    /// https://leetcode.cn/problems/maximum-value-of-an-ordered-triplet-ii/
    /// </summary>
    class MaximumTripletValue
    {
        public long Solve1(int[] nums)
        {
            long ans = 0;

            for (int j = 1; j < nums.Length - 2; j++)
            {
                long leftMax = 0;
                for (int i = 0; i < j; i++)
                {
                    leftMax = System.Math.Max(leftMax, nums[i]);
                }

                long rightMax = 0;
                for (int k = j + 1; k < nums.Length; k++)
                {
                    rightMax = System.Math.Max(rightMax, nums[k]);
                }

                ans = System.Math.Max(ans, (leftMax - nums[j]) * rightMax);
            }

            return ans;
        }

        public long Solve2(int[] nums)
        {
            int n = nums.Length;
            int[] sufMax = new int[n + 1];

            for (int i = n - 1; i > 1; i--)
            {
                sufMax[i] = System.Math.Max(sufMax[i + 1], nums[i]);
            }

            long ans = 0;
            int preMax = nums[0];

            for (int j = 1; j < n - 1; j++)
            {
                long current = (long)preMax - nums[j];
                ans = System.Math.Max(ans, current * sufMax[j + 1]);
                preMax = System.Math.Max(preMax, nums[j]);
            }

            return ans;
        }
    }
}