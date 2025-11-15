
namespace Alogorihm.Array.双指针
{
    /// <summary>
    /// 完美数对
    /// https://leetcode.cn/problems/perfect-pairs/
    /// </summary>
    class PerfectPairs
    {
        /// <summary>
        /// 解法超时
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public long Solve(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    int a = nums[i];
                    int b = nums[j];

                    int minAB = System.Math.Min(System.Math.Abs(a - b), System.Math.Abs(a + b));
                    int maxAB = System.Math.Max(System.Math.Abs(a - b), System.Math.Abs(a + b));

                    if (minAB <= System.Math.Min(System.Math.Abs(a), System.Math.Abs(b)) &&
                       System.Math.Max(System.Math.Abs(a), System.Math.Abs(b)) <= maxAB)
                    {
                        result++;
                    }
                }
            }

            return result;
        }
        
        public long Solve2(int[] nums)
        {
            // 1. 取绝对值
            long[] absNums = new long[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                absNums[i] = System.Math.Abs(nums[i]);
            }

            // 2. 排序
            System.Array.Sort(absNums);

            // 3. 双指针
            long result = 0;
            int left = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                while (absNums[right] > 2 * absNums[left] && left < right)
                {
                    left++;
                }

                result += right - left;
            }
            
            return result;
        }

    }
}