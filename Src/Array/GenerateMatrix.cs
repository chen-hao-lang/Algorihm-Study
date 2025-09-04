using System.Runtime.Versioning;

namespace Alogorihm.Array
{
    class GenerateMatrix
    {
        public int[][] Slove(int n)
        {
            int startX = 0, startY = 0;
            int loop = n / 2;
            int mid = n / 2;
            int offset = 1;
            int count = 1;

            int[][] res = new int[n][];
            for (int k = 0; k < n; k++)
            {
                res[k] = new int[n];
            }

            int i = 0, j = 0; // [i,j]
            while (loop > 0)
            {
                i = startX;
                j = startY;
                // 四个For循环模拟转一圈
                // 第一排，从左往右遍历，不取最右侧的值(左闭右开)
                for (; j < n - offset; j++)
                {
                    res[i][j] = count++;
                }
                // 右侧的第一列，从上往下遍历，不取最下面的值(左闭右开)
                for (; i < n - offset; i++)
                {
                    res[i][j] = count++;
                }

                // 最下面的第一行，从右往左遍历，不取最左侧的值(左闭右开)
                for (; j > startY; j--)
                {
                    res[i][j] = count++;
                }

                // 左侧第一列，从下往上遍历，不取最左侧的值(左闭右开)
                for (; i > startX; i--)
                {
                    res[i][j] = count++;
                }
                // 第二圈开始的时候，起始位置要各自加1， 例如：第一圈起始位置是(0, 0)，第二圈起始位置是(1, 1)
                startX++;
                startY++;

                // offset 控制每一圈里每一条边遍历的长度
                offset++;
                loop--;
            }
            if (n % 2 == 1)
            {
                // n 为奇数
                res[mid][mid] = count;
            }
            return res;
        }
    }
}