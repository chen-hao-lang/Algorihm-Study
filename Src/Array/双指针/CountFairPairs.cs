namespace Alogorihm.Array.双指针
{
    class CountFairPairs
    {
        public long Solve(int[] nums, int lower, int upper)
        {
            System.Array.Sort(nums);
            return Count(nums,upper) - Count(nums,lower - 1);
        }

        private long Count(int[] nums, int upper)
        {
            long res = 0;
            int j = nums.Length - 1;

            for (int i = 0; i < nums.Length; i++)
            {
                while (j > i && nums[j] > upper - nums[i])
                {
                    j--;
                }

                if (j == i)
                    break;

                res += j - i;
            }

            return res;
        }
    }
}