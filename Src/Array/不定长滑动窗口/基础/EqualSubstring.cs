namespace Alogorihm.Array
{
    /// <summary>
    /// 尽可能使字符串相等
    /// </summary>
    class EqualSubstring
    {
        public int Solve(string s, string t, int maxCount)
        {
            char[] s1 = s.ToCharArray();
            char[] t1 = t.ToCharArray();
            int currentCount = 0;
            int ans = 0;
            int left = 0;

            for (int right = 0; right < s1.Length; right++)
            {
                currentCount += System.Math.Abs(s1[right] - t1[right]);
                while (currentCount > maxCount)
                {
                    currentCount -= System.Math.Abs(s1[left] - t1[left]);
                    left++;
                }

                ans = System.Math.Max(ans, right - left + 1);
            }
            return ans;
        }
    }
}