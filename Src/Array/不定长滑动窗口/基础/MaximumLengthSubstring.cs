namespace Alogorihm.Array
{
    /// <summary>
    /// 每个字符最多出现两次的最长子字符串
    /// </summary>
    class MaximumLengthSubstring
    {
        public int Solve(string s)
        {
            // 转换成数组效率更高
            char[] c = s.ToCharArray();
            int n = s.Length;
            int left = 0;
            int ans = 0;
            Dictionary<char, int> map = new Dictionary<char, int>();

            // 入
            for (int right = 0; right < n; right++)
            {
                map[c[right]] = map.TryGetValue(c[right], out int value) ? value + 1 : 1;

                // 更新：维护窗口
                while (map[c[right]] > 2)
                {
                    // map[c[left]]--;
                    // left++;

                    // 另外一种写法
                    // 出
                    map[c[left++]]--;
                }

                ans = System.Math.Max(ans, right - left + 1);
            }

            return ans;
        }
    }
}