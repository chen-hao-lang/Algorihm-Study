namespace Alogorihm.Array.不定长滑动窗口.进阶
{
    /// <summary>
    /// 最大美丽值
    /// https://leetcode.cn/problems/maximum-beauty-of-an-array-after-applying-operation/
    /// </summary>
    class MaximumBeauty
    {
        public int Solve(int[] nums, int k)
        {
            System.Array.Sort(nums);

            int ans = 0;
            int left = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                while (nums[right] - nums[left] > k * 2)
                {
                    left++;
                }
                
                ans = System.Math.Max(ans, right - left + 1);   
            }
            return ans;
        }
    }
}