using System.ComponentModel;
using System.Runtime;

namespace Alogorihm.Array
{
    /// <summary>
    /// 将X减到0的最小操作数
    /// </summary>
    class MinOperations
    {
        public int Solve1(int[] nums, int x)
        {
            int ans = int.MaxValue;
            int sum = 0;

            foreach (var num in nums)
            {
                sum += num;
            }

            if (sum < 0)
            {
                return -1;
            }

            int left = 0;
            int currentSum = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                currentSum += nums[right];

                if (currentSum == sum - x)
                {
                    currentSum -= nums[left++];
                }

                ans = System.Math.Min(ans, nums.Length - (right - left + 1));
            }

            return ans;
        }

        public int Solve2(int[] nums, int x)
        {
            int sum = 0;

            foreach (var num in nums)
            {
                sum += num;
            }

            if (sum - x < 0)
                return -1;

            int ans = -1;
            int left = 0;
            int currentSum = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                currentSum += nums[right];

                while (currentSum > sum - x)
                {
                    currentSum -= nums[left++];
                }

                if (currentSum == sum - x)
                {
                    ans = System.Math.Max(ans, right - left + 1);
                }
            }

            return ans < 0 ? -1 : nums.Length - ans;
        }
    }
}