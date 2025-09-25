using System;

namespace Alogorihm.String
{
    class MaxVowels
    {
        public int Solve(string s, int k)
        {
            int ans = 0, vowel = 0;

            for (int i = 0; i < s.Length; i++)
            {
                // 1.右端点进入窗口
                if (IsVowel(s[i]))
                    vowel++;

                int left = i - k + 1;

                if (left < 0)
                    continue;

                ans = System.Math.Max(ans, vowel);

                char outChar = s[left];
                if (IsVowel(outChar))
                {
                    vowel--;
                }
            }

            return ans;
        }

        public bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}