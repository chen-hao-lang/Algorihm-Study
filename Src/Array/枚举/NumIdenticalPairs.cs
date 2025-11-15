namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 好数对的数目
    /// https://leetcode.cn/problems/number-of-good-pairs/
    /// </summary>
    class NumIdenticalPairs
    {
        public int Solve(int[] nums)
        {
            int res = 0;
            // key:nums[i]
            // value:index
            Dictionary<int,int> map = new();
            foreach(var x in nums)
            {
                if(map.ContainsKey(x))
                {
                    res += map[x];
                    map[x] ++;
                }
                else
                {
                    map.Add(x,1);
                }
            }
            return res;
        }

        public int Solve2(int[] nums)
        {
            int res = 0;
            int[] cnt = new int[101];
            foreach(var x in nums)
            {
                res += cnt[x];
                cnt[x]++;
            }
            return res;
        }
    }
}