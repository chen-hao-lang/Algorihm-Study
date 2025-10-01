using System.Reflection.PortableExecutable;

namespace Alogorihm.Array
{
    /// <summary>
    /// 拆炸弹
    /// </summary>
    class Decrypt
    {
        public int[] Solve1(int[] code, int k)
        {
            int n = code.Length;

            int r = k > 0 ? k + 1 : n;
            k = System.Math.Abs(k);

            int s = 0;
            for (int i = r - k; i < r; i++)
            {
                s += code[i];
            }

            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                ans[i] = s;
                s += code[r % n] - code[(r - k) % n];
                r++;
            }
            return ans;
        }
    }
}