namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 直角三角形
    /// https://leetcode.cn/problems/right-triangles/submissions/681857870/
    /// </summary>
    class NumberOfRightTriangles
    {
        public long Solve(int[][] grid)
        {
            int n = grid[0].Length;
            int[] colSum = new int[n];
            System.Array.Fill(colSum, -1);// 提前减1

            foreach (int[] row in grid)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    colSum[i] += row[i];
                }
            }

            long ans = 0;
            foreach (int[] row in grid)
            {
                int rowSum = -1;
                foreach (var x in row)
                {
                    rowSum += x;
                }

                for (int i = 0; i < row.Length; i++)
                {
                    if (row[i] == 1)
                    {
                        ans += rowSum * colSum[i];
                    }
                }
            }

            return ans;
        }
    }
}