namespace Alogorihm.Array
{
    /// <summary>
    /// 最长半重复子字符串
    /// https://leetcode.cn/problems/longest-semi-repetitive-substring/
    /// </summary>
    class LongestSemiRepetitiveSubstring
    {
        public int Solve(string s)
        {
            char[] c = s.ToCharArray();
            int ans = 0;
            int same = 0;
            int left = 0;

            for (int right = 1; right < c.Length; right++)
            {
                same += c[right] == c[right - 1] ? 1 : 0;

                while (same > 1)
                {
                    same -= c[left] == c[left + 1] ? 1 : 0;
                    left++;
                }

                ans = System.Math.Max(ans, right - left + 1);
            }
            
            return ans == 0 ? s.Length : ans;
        }
    }   
}