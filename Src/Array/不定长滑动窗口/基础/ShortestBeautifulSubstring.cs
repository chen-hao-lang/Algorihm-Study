namespace Alogorihm.Array.不定长滑动窗口
{
    /// <summary>
    /// 1763. 最短的美好子字符串
    /// https://leetcode.cn/problems/longest-nice-substring/
    /// </summary>
    class ShortestBeautifulSubstring
    {
        public string Solve(string s, int k)
        {
            // if (s.Replace('0', ' ').Length < k)
            // {
            //     return "";
            // }
            //  直接统计原字符串中1的个数
            if (s.Count(c => c == '1') < k)
            {
                return "";
            }

            char[] c = s.ToCharArray();
            int left = 0;
            int cnt1 = 0;
            string ans = "";

            for (int right = 0; right < s.Length; right++)
            {
                cnt1 += c[right] == '1' ? 1 : 0;

                // 收缩窗口：保证cnt1≤k，且去掉左侧多余的0（不影响1的数量）
                while (cnt1 > k || c[left] == '0')
                {
                    cnt1 -= s[left] == '1' ? 1 : 0;
                    left++;
                }

                if (cnt1 == k)
                {
                    // 记录当前窗口字符串
                    string t = s.Substring(left, right - left + 1);
                    // if (t.Length < ans.Length || t.Length == ans.Length && t.CompareTo(ans) < 0)
                    // {
                    //     ans = t;
                    // }

                    // 更新答案：优先选短的，同长选字典序小的
                    if (string.IsNullOrEmpty(ans) ||
                        t.Length < ans.Length ||
                        t.Length == ans.Length && t.CompareTo(ans) < 0)
                    {
                        ans = t;
                    }
                }
            }

            return ans;
        }
    }
}