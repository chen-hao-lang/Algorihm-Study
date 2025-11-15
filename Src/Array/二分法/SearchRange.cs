using System.ComponentModel;

namespace Alogorihm.Array.二分法
{
    /// <summary>
    /// 在排序数组中查找元素的第一个和最后一个位置
    /// https://leetcode.cn/problems/find-first-and-last-position-of-element-in-sorted-array/
    /// </summary>
    class SearchRange
    {
        public int[] Solve(int[] nums, int target)
        {
            int leftIndex = FindLeftIndex(nums, target);
            int rightIndex = FindRightIndex(nums, target);
            return new int[] { leftIndex, rightIndex };
        }

        private int FindRightIndex(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int rightIndex = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }

                if (nums[mid] == target)
                {
                    rightIndex = mid;
                }
            }

            return rightIndex;
        }

        private int FindLeftIndex(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int leftIndex = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

                if (nums[mid] == target)
                {
                    leftIndex = mid;
                }
            }

            return leftIndex;
        }
    }
}