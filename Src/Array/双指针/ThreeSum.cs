namespace Alogorihm.Array.双指针
{
    /// <summary>
    /// 三数之和
    /// https://leetcode.cn/problems/3sum/description/
    /// </summary>
    class ThreeSum
    {
        public IList<IList<int>> Solve(int[] nums)
        {
            System.Array.Sort(nums);
            int n = nums.Length;
            List<IList<int>> ans = new List<IList<int>>();

            for (int i = 0; i < n - 2; i++)
            {
                int x = nums[i];
                if (i > 0 && x == nums[i - 1]) continue;
                if (x + nums[i + 1] + nums[i + 2] > 0) break; // 优化一
                if (x + nums[n - 2] + nums[n - 1] < 0) continue; // 优化二

                int j = i + 1;
                int k = n - 1;

                while (j < k)
                {
                    int sum = x + nums[j] + nums[k];
                    if (sum > 0)
                    {
                        k--;
                    }
                    else if (sum < 0)
                    {
                        j++;
                    }
                    else
                    {
                        ans.Add(new List<int>() { x, nums[j], nums[k] });
                        for (j++; j < k && nums[j] == nums[j - 1]; j++) ;
                        for (k--; j < k && nums[k] == nums[k + 1]; k--) ;
                    }
                }
            }
            return ans;
        }
    }
}