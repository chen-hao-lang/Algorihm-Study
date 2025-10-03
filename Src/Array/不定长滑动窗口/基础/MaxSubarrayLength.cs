namespace Alogorihm.Array
{
    /// <summary>
    /// 最多K个重复元素的最长子数组
    /// </summary>
    class MaxSubarrayLength
    {
        public int Solve(int[] nums, int k)
        {
            int ans = 0;
            int left = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int right = 0; right < nums.Length; right++)
            {
                //map[nums[right]] = map.TryGetValue(nums[right], out int value) ? value + 1 : 1;
                map.TryAdd(nums[right],0);
                map[nums[right]]++;

                while (map[nums[right]] > k)
                {
                    if (map.ContainsKey(nums[left]))
                    {
                        map[nums[left]]--;

                        if (map[nums[left]] == 0)
                        {
                            map.Remove(nums[left]);
                        }
                    }

                    left++;
                }

                ans = System.Math.Max(ans, right - left + 1);
            }
            
            return ans; 
        }
    }
}
