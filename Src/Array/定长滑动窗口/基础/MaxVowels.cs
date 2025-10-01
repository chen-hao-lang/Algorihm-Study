namespace Alogorihm.Array
{
    class MaxVowels
    {
        public int Solve(string s, int k)
        {
            char[] c = s.ToCharArray();
            int ans = 0, sum = 0;

            for (int i = 0; i < c.Length; i++)
            {
                sum += IsVowel(c[i]) ? 1 : 0;

                int left = i - k + 1;
                if (left < 0)
                    continue;

                ans = System.Math.Max(ans, sum);

                sum -= IsVowel(c[left++]) ? 1 : 0;
            }

            return ans;
        }

        public bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}