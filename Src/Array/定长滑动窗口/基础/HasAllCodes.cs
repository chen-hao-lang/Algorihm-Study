namespace Alogorihm.Array.定长滑动窗口
{
    class HasAllCodes
    {
        public bool Solve(string s, int k)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            int left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                left = right - k + 1;
                if (left < 0)
                {
                    continue;
                }

                string str = s.Substring(left, k);
                if (!map.ContainsKey(str))
                {
                    map[str] = 0;
                }
                else
                {
                    map[str]++;
                }

                if (map.Count == (1 << k))
                {
                    return true;
                }
            }

            return false;
        }
    }
}