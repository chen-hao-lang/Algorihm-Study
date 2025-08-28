namespace Alogorihm.Array
{
    public class TwoSum
    {
        /// <summary>
        /// 暴力解法
        /// </summary>
        /// <param name="nums">输入数组</param>
        /// <param name="target">目标和</param>
        /// <returns>两个数的索引</returns>
        public int[] SolveBruteForce(int[] nums, int target)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// 哈希表优化解法
        /// </summary>
        /// <param name="nums">输入数组</param>
        /// <param name="target">目标和</param>
        /// <returns>两个数的索引</returns>
        public int[] SolveWithHashTable(int[] nums, int target)
        {
            // 实现哈希表解法
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            return null;
        }
    }
}