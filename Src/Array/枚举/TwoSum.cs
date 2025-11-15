namespace Alogorihm.Array.枚举
{
    class TwoSum
    {
        /// <summary>
        /// 暴力解法
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] Solve(int[] nums,int target)
        {
            for(int i = 0;i<nums.Length;i++)
            {
                for(int j = i+1;j<nums.Length;j++)
                {
                    if(nums[i] + nums[j] ==target)
                        return new int[]{i,j};
                }
            }

            return null;
        }

        public int[] Solve2(int[] nums,int target)
        {
            Dictionary<int,int> map  = new Dictionary<int, int>();

            for(int i = 0;i<nums.Length;i++)
            {
                int temp = target - nums[i];
                if(map.ContainsKey(temp))
                {
                    return new int[]{i,map[temp]};
                }
                else
                {
                    map.Add(nums[i],i);
                }
            }

            return new int[0];
        }
    }
}