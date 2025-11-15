using System.ComponentModel;
using System.Reflection;

namespace Alogorihm.Array.二分法
{
    class CountFairPairs
    {
        // 错误
        public long Solve1(int[] nums, int lower, int upper)
        {
            System.Array.Sort(nums);
            long res = 0;

            for (int left = 0; left < nums.Length; left++)
            {
                for (int right = nums.Length - 1; right > left; right--)
                {
                    int temp = nums[left] + nums[right];
                    if (right > left && temp > lower && temp < upper)
                    {
                        res++;
                    }
                    else if (right > left && temp > upper)
                    {
                        right--;
                    }
                    else if (right > left && temp < lower)
                    {
                        left++;
                    }
                }
            }
            return res;
        }

        // 二分查找    
        public long Solve2(int[] nums, int lower, int upper)
        {
            System.Array.Sort(nums);
            long res = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                int r = LowerBound(nums, j, upper - nums[j] + 1);
                int l = LowerBound(nums, j, lower - nums[j]);
                res += r - l;
            }
            return res;
        }

        private int LowerBound(int[] nums, int right, int target)
        {
            int left = -1;

            while (left + 1 < right)
            {
                int mid = (left + right) >>> 1;

                if (nums[mid] >= target)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }

            return right;
        }
    }
}