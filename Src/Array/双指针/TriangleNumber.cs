using Alogorihm.Array.不定长滑动窗口;

namespace Alogorihm.Array.双指针
{
    /// <summary>
    /// 有效的三角形个数
    /// https://leetcode.cn/problems/valid-triangle-number/submissions/674527278/
    /// </summary>
    class TriangleNumber
    {
        /// <summary>
        /// 超时解法
        /// 固定最小边 i 而非最大边，双指针无法批量统计有效组合，效率低下
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Solve(int[] nums)
        {
            System.Array.Sort(nums);
            int n = nums.Length;

            if (n < 3) return 0;// 

            int ans = 0;

            for (int i = 0; i < n - 2; i++)
            {
                int x = nums[i];

                int j = i + 1;
                int k = n - 1;

                while (j < k)
                {
                    int sum = x + nums[j];

                    if (sum > nums[k])
                    {
                        ans++;
                    }
                    else if (sum == nums[k])
                    {
                        j++;
                    }
                    else// sum<nums[k]
                    {
                        k--;
                    }
                }
            }

            return ans;
        }

        public int Solve2(int[] nums)
        {
            System.Array.Sort(nums);

            int n = nums.Length;

            if (n < 3) return 0;

            int ans = 0;

            for (int k = n - 1; k >= 2; k--)
            {
                int i = 0;
                int j = k - 1;

                while (i < j)
                {
                    if (nums[i] + nums[j] > nums[k])
                    {
                        ans += j - i;
                        j--;
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return ans;
        }
    }
}