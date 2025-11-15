using System.ComponentModel;

namespace Alogorihm.Array.二分法
{
    class MaximumCount
    {
        public int Solve1(int[] nums)
        {
            int res1 = 0;
            int res2 = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                res1 += nums[i] > 0 ? 1 : 0;
                res2 += nums[i] < 0 ? 1 : 0;
            }

            return System.Math.Max(res1, res2);
        }

        public int Solve2int(int[] nums)
        {
            int res1 = LowerBound(nums, 0);
            int res2 = nums.Length - LowerBound(nums,1);
            return System.Math.Max(res1, res2);
        }

        private int LowerBound(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (right + left) >>> 1;
                if (nums[mid] >= target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return left;
        }
    }
}