using System.Globalization;
using System.Runtime.InteropServices;

namespace Alogorihm
{
    class IsValidSudoku
    {
        public bool Slove(char[][] board)
        {
            int[,] rows = new int[9, 9];
            int[,] columers = new int[9, 9];
            int[,,] sub = new int[3, 3, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    char c = board[i][j];

                    if (c != '.')
                    {
                        int index = c - '0' - 1;
                        //记录每行每个数字出现的次数
                        rows[i, index]++;
                        //记录每列每个数字出现的次数
                        columers[j, index]++;
                        sub[i / 3, j / 3, index]++;

                        if (rows[i, index] > 1 || columers[j, index] > 1 || sub[i / 3, j / 3, index] > 1)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}