namespace Alogorihm.Array.前缀和
{
    class SubarraySum
    {
        public int Solve(int[] nums)
        {
            int n = nums.Length;
            int[] subArray = new int[n + 1];

            int ans = 0;
            for (int i = 1; i < n; i++)
            {
                subArray[i] = nums[i - 1] + subArray[i - 1];
            }

            foreach (var x in subArray)
            {
                ans += x;
            }

            return ans;
        }

        public int Solve1(int[] nums)
        {
            int n = nums.Length;
            int[] subArray = new int[n + 1];

            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                subArray[i + 1] = nums[i] + subArray[i];
            }

            for (int i = 0; i < n; i++)
            {
                int left = System.Math.Max(0, i - nums[i]);
                ans += subArray[i + 1] - subArray[left];
            }

            return ans;
        }
    }
}