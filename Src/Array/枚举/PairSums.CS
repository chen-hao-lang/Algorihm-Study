using System.Data;

namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 面试16.24 数对和
    /// https://leetcode.cn/problems/pairs-with-sum-lcci/
    /// </summary>
    class PairSums
    {
        public IList<IList<int>> Solve(int[] nums, int target)
        {
            List<IList<int>> ans = new List<IList<int>>();
            Dictionary<int, int> map = new();

            foreach (var num in nums)
            {
                int targetNum = target - num;
                if (map.ContainsKey(targetNum))
                {
                    ans.Add(new List<int>() { num, targetNum });
                    map[targetNum]--;
                    if (map[targetNum] == 0) map.Remove(targetNum);
                }
                else
                {
                    if(map.ContainsKey(num))
                    {
                        map[num] +=1;
                    }
                    else
                        map[num] = 1;
                }
            }
            return ans;
        }
    }
}