namespace Alogorihm.Geometry
{
    public class AreaOfMaxDiagonal
    {
        //对角线最长的矩形的面积
        public int MaxDiagonalRectangleArea(int[][] dimensions)
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
    }
}