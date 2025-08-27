class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        //解法1：暴力
        //循环遍历数组，找到两个数之和等于目标值的两个数组下标
        //返回这两个下标
        int n = nums.Length;    
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < nums.length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }

        return null;
    }
}