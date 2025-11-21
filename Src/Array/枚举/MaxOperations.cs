using System.ComponentModel;
using System.Data;

namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// K和数对的最大数目
    /// https://leetcode.cn/problems/max-number-of-k-sum-pairs/
    /// </summary>
    class MaxOperations
    {
        public int Solve(int[] nums, int k)
        {
            int ans = 0;
            Dictionary<int, int> map = new();
            foreach (var num in nums)
            {
                int target = k - num;
                if (map.ContainsKey(target) && map[target] > 0)
                {
                    ans += 1;
                    map[target] -= 1;

                    if (map[target] == 0)
                        map.Remove(target);
                }
                else
                {
                    if (map.ContainsKey(num))
                    {
                        map[num]++;
                    }
                    else
                    {
                        map[num] = 1;
                    }
                }
            }
            return ans;
        }

        public int Solve2(int[] nums, int k)
        {
            int ans = 0;
            int[] map = new int[1001];
            foreach (var num in nums)
            {
                int target = k - num;
                if(map[target] >=1)
                {
                    ans+= 1;
                    map[target] -= 1;
                }

                map[target] +=1;
            }
            return ans;
        }
    }
}