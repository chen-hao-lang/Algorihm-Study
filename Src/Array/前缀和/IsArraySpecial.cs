using System.Data.SqlTypes;

namespace Alogorihm.Array.前缀和
{
    class IsArraySpecial
    {
        public bool[] Solve1(int[] nums, int[][] queries)
        {
            int n = nums.Length;
            int[] preSum = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                preSum[i + 1] = preSum[i] + nums[i];
            }

            bool[] ans = new bool[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int left = queries[i][0];
                int right = queries[i][1];

                int temp = preSum[right + 1] - preSum[left];
                if (temp % 2 != 0)
                {
                    ans[i] = true;
                }
            }

            return ans;
        }

        public bool[] Solve2(int[] nums, int[][] queries)
        {
            int[] s = new int[nums.Length + 1];
            for (int i = 1; i < nums.Length; i++)
            {
                s[i + 1] = s[i] + (nums[i] % 2 == nums[i - 1] % 2 ? 1 : 0);
            }

            bool[] ans = new bool[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int[] q = queries[i];
                ans[i] = s[q[0]] == s[q[1]];
            }

            return ans;
        }

        public bool[] Solve3(int[] nums, int[][] queries)
        {
            int n = nums.Length;
            // 结果数组，长度与查询数一致
            bool[] results = new bool[queries.Length];

            // 特殊情况处理：数组为空或长度为0，所有查询返回false（实际题目中nums非空）
            if (n == 0) return results;

            // 1. 构建差异数组diff：标记相邻元素奇偶性是否相同
            // diff[i] = 1 表示 nums[i] 和 nums[i+1] 奇偶性相同（违规）
            // diff[i] = 0 表示 nums[i] 和 nums[i+1] 奇偶性不同（合规）
            int[] diff = new int[n - 1];
            for (int i = 0; i < n - 1; i++)
            {
                // 判断相邻元素奇偶性是否相同：(nums[i] % 2) == (nums[i+1] % 2)
                // 若相同则标记为1（违规），否则为0（合规）
                diff[i] = (nums[i] % 2) == (nums[i + 1] % 2) ? 1 : 0;
            }

            // 2. 构建前缀和数组preDiff：快速计算区间内的违规相邻对数量
            // preDiff[0] = 0，preDiff[i] = diff[0] + diff[1] + ... + diff[i-1]
            int[] preDiff = new int[diff.Length + 1];
            for (int i = 0; i < diff.Length; i++)
            {
                preDiff[i + 1] = preDiff[i] + diff[i];
            }

            // 3. 处理每个查询
            for (int q = 0; q < queries.Length; q++)
            {
                int from = queries[q][0];
                int to = queries[q][1];

                // 子数组长度为1（from == to）：天然符合条件（无相邻元素）
                if (from == to)
                {
                    results[q] = true;
                    continue;
                }

                // 计算查询区间 [from, to] 对应的违规相邻对数量
                // 关键：子数组 [from, to] 的相邻元素对是 (from,from+1), (from+1,from+2), ..., (to-1,to)
                // 对应diff数组的区间是 [from, to-1]，前缀和差值 = preDiff[to] - preDiff[from]
                int invalidCount = preDiff[to] - preDiff[from];

                // 若违规数量为0：子数组符合条件；否则不符合
                results[q] = invalidCount == 0;
            }

            return results;
        }
    }
}