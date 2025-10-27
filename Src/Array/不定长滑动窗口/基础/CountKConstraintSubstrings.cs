using System.Data;

namespace Alogorihm.Array.不定长滑动窗口
{
    /// <summary>
    /// 统计满足K约束的子字符串数量|
    /// https://leetcode.cn/problems/count-substrings-that-satisfy-k-constraint-i/
    /// </summary>
    class CountKConstraintSubstrings
    {
        public int Slove(string s, int k)
        {
            char[] c = s.ToCharArray();

            int left = 0;
            int ans = 0;
            int[] map = new int[] { 0, 0 };

            for (int right = 0; right < c.Length; right++)
            {
                map[0] += c[right] == '0' ? 1 : 0;
                map[1] += c[right] == '1' ? 1 : 0;

                while (map[0] > k && map[1] > k)
                {
                    map[0] -= c[left] == '0' ? 1 : 0;
                    map[1] -= c[left] == '1' ? 1 : 0;
                    left++;
                }

                ans += right - left + 1;
            }

            return ans;
        }
    }
}