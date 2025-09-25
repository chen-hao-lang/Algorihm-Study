namespace Alogorihm.Array
{
    /// <summary>
    /// 得到K个黑块的最少涂色次数
    /// </summary>
    class MinimumRecolors
    {
        public int Solve(string blocks, int k)
        {
            int res = int.MaxValue;
            int changeNUm = 0;
            // 1.入
            for (int i = 0; i < blocks.Length; i++)
            {
                if (blocks[i] == 'W')
                {
                    changeNUm++;
                }

                int left = i - k + 1;
                if (left < 0)
                {
                    continue;
                }

                res = int.Min(res, changeNUm);
                if (blocks[i - k + 1] == 'W')
                {
                    changeNUm--;
                }
            }
            // 2.更新
            // 3.出

            // 右指针移动，如果是黑色块则加1
            return res;
        }
    }
}