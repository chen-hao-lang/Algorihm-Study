namespace Alogorihm.Array.不定长滑动窗口
{
    /// <summary>
    /// 包含所有字符的最小子串数目
    /// https://leetcode.cn/problems/number-of-substrings-containing-all-three-characters/
    /// </summary>
    class NumberOfSubstrings
    {
        public int Slove(string s)
        {
            int n = s.Length;
            int[] count = new int[3];
            int left = 0;
            int ans = 0;

            for (int right = 0; right < n; right++)
            {
                count[s[right] - 'a']++;

                while (count[0] > 0 && count[1] > 0 && count[2] > 0)
                {
                    count[s[left] - 'a']--;
                    left++;
                }

                ans += left;
            }
            
            return ans;
        }
    }
}