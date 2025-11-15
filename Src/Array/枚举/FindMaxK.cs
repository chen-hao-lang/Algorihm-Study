namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 与对应负数同时存在的最大正整数
    /// https://leetcode.cn/problems/largest-positive-integer-that-exists-with-its-negative/description/
    /// </summary>
    class FindMaxK
    {
        public int Solve1(int[] nums)
        {
            int maxNum = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == 0)
                    {
                        maxNum = System.Math.Max(System.Math.Abs(nums[i]), maxNum);
                    }
                }
            }

            return maxNum;
        }

        public int Solve2(int[] nums)
        {
            int maxNum = -1;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int temp = 0 - nums[i];
                // temp + nums[j] = 0
                if (map.ContainsValue(temp))
                {
                    maxNum = System.Math.Max(System.Math.Abs(temp), maxNum);
                }
                else
                {
                    map.Add(i, nums[i]);
                }
            }

            return maxNum;
        }

        public int Solve3(int[] nums)
        {
            // 键：目标负数值
            // 值：无意义占位符
            // Dictionary 的核心优势是 “通过键快速查找”，底层是哈希表，ContainsKey 时间复杂度是 O (1)
            Dictionary<int, int> info = new();
            int res = -1;
            foreach (int i in nums)
            {
                if (info.ContainsKey(i)) res = System.Math.Max(res, System.Math.Abs(i));
                else if (!info.ContainsKey(-i)) info.Add(-i, 0);
            }
            return res;
        }
    }
}