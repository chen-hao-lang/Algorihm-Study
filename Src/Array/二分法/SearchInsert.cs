namespace Alogorihm.Array.二分法
{
    /// <summary>
    /// 搜索插入位置
    /// https://leetcode.cn/problems/search-insert-position/
    /// </summary>
    class SearchInsert
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

            return left;
        }
    }
}