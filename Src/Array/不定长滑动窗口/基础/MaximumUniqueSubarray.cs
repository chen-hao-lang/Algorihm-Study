namespace Alogorihm.Array
{
    /// <summary>
    /// 删除子数组的最大得分
    /// </summary>
    class MaximumUniqueSubarray
    {
        public int Solve(int[] nums)
        {
            int ans = 0;
            int left = 0;
            int sum = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int right = 0; right < nums.Length; right++)
            {
                //map[nums[right]] = map.GetValueOrDefault(nums[right], 0) + 1;
                map[nums[right]] = map.TryGetValue(nums[right], out int value) ? value + 1 : 1;
                sum += nums[right];

                while (map[nums[right]] > 1)
                {
                    sum -= nums[left];
                    map[nums[left]]--;

                    if (map[nums[left]] == 0)
                    {
                        map.Remove(nums[left]);
                    }

                    left++;
                }

                //ans = System.Math.Max(ans, map.Keys.Sum(x => x + map[x]));
                ans = System.Math.Max(ans,sum);
            }
            return ans;
        }
    }
}