using System.ComponentModel;

namespace Alogorihm.Array.不定长滑动窗口
{
    /// <summary>
    /// 713. 乘积小于 K 的子数组
    /// https://leetcode.cn/problems/subarray-product-less-than-k/
    /// </summary>
    class NumSubarrayProductLessThanK
    {
        public int Solve2(int[] nums, int k)
        {
            if (k <= 1)
                return 0;

            int ans = 0;
            int left = 0;
            int product = 1;

            for (int right = 0; right < nums.Length; right++)
            {
                product *= nums[right];

                while (left <= right && product >= k)
                {
                    product /= nums[left];
                    left++;
                }

                ans += right - left + 1;
            }

            return ans;
        }
    }
}