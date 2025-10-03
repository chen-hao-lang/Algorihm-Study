namespace Alogorihm.Array
{
    /// <summary>
    /// 考试的最大困扰度
    /// </summary>
    class MaxConsecutiveAnswers
    {
        public int Solve(string answerKey, int k)
        {
            char[] c = answerKey.ToCharArray();
            int letf = 0;
            int[] map = new int[2];
            int ans = 0;

            for (int right = 0; right < c.Length; right++)
            {
                map[0] += c[right] == 'T' ? 1 : 0;
                map[1] += c[right] == 'F' ? 1 : 0;

                while (map[0] > k && map[1] > k)
                {
                    map[0] -= c[letf] == 'T' ? 1 : 0;
                    map[1] -= c[letf] == 'F' ? 1 : 0;
                    letf++;
                }

                ans = System.Math.Max(ans, right - letf + 1);
            }
            
            return ans; 
        }
    }
}