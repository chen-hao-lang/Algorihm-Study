namespace Alogorihm.Array
{
    /// <summary>
    /// 好数对的题目
    /// </summary>
    class NumIdenticalPairs
    {
        public int Slove(int[] nums)
        {
            int res = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = 1; j < nums.Length; j++)
                {
                    if (i < j && nums[i] == nums[j])
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}