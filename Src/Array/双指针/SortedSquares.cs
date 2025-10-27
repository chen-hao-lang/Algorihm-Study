namespace Alogorihm.Array.双指针
{
    /// <summary>
    /// 977.有序数组的平方
    /// https://leetcode.cn/problems/squares-of-a-sorted-array/
    /// </summary>
    class SortedSquares
    {
        public int[] Solve(int[] nums)
        {
            int[] res = new int[nums.Length];
            int index = nums.Length - 1;
            int left = 0, right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] * nums[left] < nums[right] * nums[right])
                {
                    res[index--] = nums[right] * nums[right];
                    right--;
                }
                else
                {
                    res[index--] = nums[left] * nums[left];
                    left++;
                }
            }

            return res;

        }
    }
}