namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 长度为3的不同回文子序列
    /// </summary>
    class CountPalindromicSubsequence
    {
        public int Solve(string s)
        {
            char[] c = s.ToCharArray();
            int n = c.Length;

            int[] sufCnt = new int[26];
            for (int i = 1; i < n; i++)
            {
                sufCnt[c[i] - 'a']++;
            }

            bool[] preHas = new bool[26];
            bool[][] has = new bool[26][];// 去重：has[m][c] 表示 (c,m,c) 是否已统计
            for (int i = 0; i < has.Length; i++)
            {
                has[i] = new bool[26];
            }

            int ans = 0;

            for (int i = 1; i < n - 1; i++)
            {
                int target = c[i] - 'a';
                sufCnt[target]--;
                preHas[c[i - 1] - 'a'] = true;

                for (int alpha = 0; alpha < 26; alpha++)
                {
                    if(preHas[alpha] && sufCnt[alpha]>0 && !has[target][alpha])
                    {
                        has[target][alpha] = true;
                        ans++;
                    }
                }
            }

            return ans;
        }
    }
}