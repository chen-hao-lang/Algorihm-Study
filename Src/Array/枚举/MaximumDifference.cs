namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 增量元素之间的最大差值
    /// https://leetcode.cn/problems/maximum-difference-between-increasing-elements/description/
    /// </summary>
    class MaximumDifference
    {
        public int Solve(int[] nums)
        {
            int res = 0;
            int preMin = int.MaxValue;
            foreach (var x in nums)
            {
                res = System.Math.Max(res, x - preMin);
                preMin = System.Math.Min(preMin, x);
            }

            return res > 0 ? res : -1;
        }
    }
}