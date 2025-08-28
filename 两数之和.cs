using System.Runtime.CompilerServices;

class Solution
{
    //对角线最长的矩形的面积
    public int AreaOfMaxDiagonal(int[][] dimensions)
    {
        //先计算对角线的长度
        //比较对角线长度
        //返回对角线长度最长的矩形的面积
        //注意对角线长度一致的情况
        float maxLength = 0;
        int maxArea = 0;
        for (int i = 0; i < dimensions.Length; i++)
        {
            float l = dimensions[i][0];
            float w = dimensions[i][1];
            float dis = l * l + w * w;
            int area = dimensions[i][0] * dimensions[i][1];

            if (dis > maxLength)
            {
                maxArea = area;
                maxLength = dis;
            }
            else if (dis == maxLength)
            {
                MathF.Max(maxArea, area);
            }
        }
        return maxArea;
    }

    //有序数组的平方

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