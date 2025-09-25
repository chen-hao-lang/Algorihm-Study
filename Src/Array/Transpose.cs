namespace Alogorihm.Array
{
    /// <summary>
    /// 转置矩阵
    /// </summary>
    class Transpose
    {
        public int[][] Slove1(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int[][] res = new int[n][];

            for (int i = 0; i < n; i++)
            {
                res[i] = new int[m];
            }

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    res[j][i] = matrix[i][j];
                }
            }

            return res;
        }
    }
}