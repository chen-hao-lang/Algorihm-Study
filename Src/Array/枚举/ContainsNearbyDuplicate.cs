using System.Globalization;
using Alogorihm.Array.不定长滑动窗口;

namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 存在重复元素||
    /// https://leetcode.cn/problems/contains-duplicate-ii/
    /// </summary>
    class ContainsNearbyDuplicate
    {
        public bool Solve(int[] nums, int k)
        {
            // key:nums[i]
            // index:index:记录每个数上次出现的位置下标
            Dictionary<int, int> map = new();
            for (int i = 0; i < nums.Length; i++)
            {
                // if(map.TryGetValue(nums[i],out int value))
                // {
                //     //map[]
                //     int temp  = System.Math.Abs(i - value);
                //     if(i > value && temp<=k)
                //     {
                //         return true;
                //     }
                // }
                // else
                // {
                //     map[nums[i]] = i;
                // }

                int x = nums[i];
                if (map.ContainsKey(x) && i - map[x] <= k)
                {
                    return true;
                }
                map[x] = i;

            }
            return false;
        }

        // 滑动窗口
        public bool Solve2(int[] nusm, int k)
        {
            HashSet<int> map = new();
            for (int i = 0; i < nusm.Length; i++)
            {
                if (!map.Add(nusm[i]))
                {
                    return true;
                }
                if (i >= k)
                {
                    map.Remove(nusm[i - k]);
                }
            }

            return false;
        }
    }
}