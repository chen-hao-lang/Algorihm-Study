using System.Runtime.CompilerServices;

class Solution
{
    //对角线遍历
    public int[] FindDiagonalOrder(int[][] mat)
    {
        int length = mat.Length;
        int width = mat[0].Length;
        int[] res = new int[length * width];
        int pos = 0;

        for (int i = 0; i < length + width - 2; i++)
        {
            if (i % 2 == 1)
            {
                int x = i < width ? 0 : i - width + 1;
                int y = i < width ? i : width - 1;
                while (x < length && y >= 0)
                {
                    res[pos++] = mat[x++][y--];
                }
            }
            else
            {
                int x = i < length ? i : length - 1;
                int y = i < length ? 0 : i - length + 1;

                while (true)
                {
                    res[pos++] = mat[x--][y++];
                }
            }
        }

        return res;
    }
}