using System.Security.AccessControl;

namespace Alogorihm.Array.二分法
{
    /// <summary>
    /// 二分查找
    /// https://leetcode.cn/problems/binary-search/
    /// </summary>
    class Search
    {
        public int Solve(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}