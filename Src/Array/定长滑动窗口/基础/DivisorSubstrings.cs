namespace Alogorihm.Array.定长滑动窗口
{
    class DivisorSubstrings
    {
        public int Solve(int num, int k)
        {
            string s = num.ToString();
            int ans = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (i + k > s.Length)
                {
                    break;
                }

                int sub = int.Parse(s.Substring(i, k));
                if (sub != 0 && num % sub == 0)
                {
                    ans++;
                }
            }

            return ans;
        }
    }
}