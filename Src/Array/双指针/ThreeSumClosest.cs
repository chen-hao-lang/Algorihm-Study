namespace Alogorihm.Array.双指针
{
    /// <summary>
    /// 16.最接近的三数之和
    /// https://leetcode.cn/problems/3sum-closest/
    /// </summary>
    class ThreeSumClosest
    {
        public int Solve(int[] nums, int target)
        {
            // 对数组排序
            System.Array.Sort(nums);
            int n = nums.Length;
            int sum = 0;
            int minDiff = int.MaxValue;
            int ans = 0;

            // 判断nums
            for (int i = 0; i < n - 2; i++)
            {
                int j = i + 1;
                int k = n - 1;

                while (j < k)
                {
                    sum = nums[i] + nums[j] + nums[k];
                    //minDiff = System.Math.Abs(sum - target);

                    if (sum == target)
                    {
                        return sum;
                    }

                    if (sum > target)
                    {
                        if (sum - target < minDiff)
                        {
                            minDiff = sum - target;
                            ans = sum;
                        }
                        k--;
                    }
                    else
                    {
                        if (target - sum < minDiff)
                        {
                            minDiff = target - sum;
                            ans = sum;
                        }
                        j++;
                    }
                }
            }

            return ans;
        }
    }
}