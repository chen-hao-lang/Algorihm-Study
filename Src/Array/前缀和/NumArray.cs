using Alogorihm.Math;

namespace Alogorihm.Array.前缀和
{
    /// <summary>
    /// 303. 区域和检索 - 数组不可变
    /// https://leetcode.cn/problems/range-sum-query-immutable/
    /// </summary>
    class NumArray
    {
        int[] _num;
        int sum = 0;
        public NumArray(int[] nums)
        {
            this._num = nums;
            sum = nums.Sum();
        }

        public int SumRange(int left, int right)
        {
            int rangeSum = 0;
            for (int i = left; i <= right; i++)
            {
                rangeSum += _num[i];
            }
            return rangeSum;
        }
    }

    class NumArray1
    {
        int[] sumNum;
        public NumArray1(int[] nums)
        {
            sumNum = new int[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                sumNum[i + 1] = sumNum[i] + nums[i];
            }
        }

        public int SumRange(int left, int right)
        {
            return sumNum[right + 1] - sumNum[left];
        }
    }
}