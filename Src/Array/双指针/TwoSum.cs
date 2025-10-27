namespace Alogorihm.Array.双指针
{
    /// <summary>
    /// 167.两数之和|| -输入有序数组
    /// https://leetcode.cn/problems/two-sum-ii-input-array-is-sorted/
    /// </summary>
    class TwoSum
    {
        public int[] Solve(int[] numbers, int target)
        {
            int letf = 0;
            int right = numbers.Length - 1;
            int sum = 0;

            while (letf < right)
            {
                sum = numbers[letf] + numbers[right];

                if (sum == target)
                {
                    return new int[] { letf + 1, right + 1 };
                }
                
                letf += sum < target ? 1 : 0;
                right -= sum > target ? 1 : 0;
            }

            return new int[] { 0, 0 };
        }

        public int[] Solve2(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (true)
            {
                int s = numbers[left] + numbers[right];

                if (s == target)
                    return new int[] { left + 1, right + 1 };

                if (s > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }
    }
}