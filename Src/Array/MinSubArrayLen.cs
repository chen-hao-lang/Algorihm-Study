namespace Alogorihm.Array
{
    /// <summary>
    /// 长度最小的子数组
    /// 给定一个含有 n 个正整数的数组和一个正整数 target 。
    // 找出该数组中满足其总和大于等于 target 的长度最小的 子数组 [numsl, numsl+1, ..., numsr-1, numsr] ，并返回其长度。如果不存在符合条件的子数组，返回 0 。
    // 示例 1：
    // 输入：target = 7, nums = [2,3,1,2,4,3]
    // 输出：2
    // 解释：子数组 [4,3] 是该条件下的长度最小的子数组。
    // 示例 2：
    // 输入：target = 4, nums = [1,4,4]
    // 输出：1
    // 示例 3：
    // 输入：target = 11, nums = [1,1,1,1,1,1,1,1]
    // 输出：0
    /// </summary>
    class MinSubArrayLen
    {
        public int Slove(int[] nums, int target)
        {
            //滑动窗口
            int res = int.MaxValue;
            int length = 0;
            int left = 0;
            int sum = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];

                while (sum >= target)
                {
                    length = right - left + 1;
                    res = res < length ? res : length;
                    sum -= nums[left];
                    left++;
                }
            }

            return res == int.MaxValue ? 0 : res;
        }
    }
}