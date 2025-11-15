namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 可互换矩形的组数
    /// https://leetcode.cn/problems/number-of-pairs-of-interchangeable-rectangles/description/
    /// </summary>
    class InterchangeableRectangles
    {
        // public long Solve(int[][] rectangles)
        // {
        //     long res = 0;
        //     Dictionary<int,int> map = new();

        //     for(int i = 0;i<rectangles.Length;i++)
        //     {
        //         int temp = rectangles[i][0] / rectangles[i][1];
        //         if(map.ContainsKey(temp))
        //         {
        //             res += map[temp];
        //             map[temp]++;
        //         }
        //         else
        //         {
        //             map.Add(temp,1);
        //         }
        //     }
        //     return res;
        // }

        public long Solve1(int[][] rectangles)
        {
            long res = 0;
            Dictionary<Tuple<int,int>,int> map = new();

            foreach(var rect in rectangles)
            {
                int width = rect[0];
                int height = rect[1];
                int gcdVal = CalculateGcd(width,height);
                int simplifiedW = width / gcdVal;
                int simplifiedH = height/gcdVal;
                var key = Tuple.Create(simplifiedW,simplifiedH);

                if(map.ContainsKey(key))
                {
                    res += map[key];
                    map[key]++;
                }
                else
                {
                    map[key] = 1;
                }
            }

            return res;
        }

        private int CalculateGcd(int width, int height)
        {
            while(height !=0)
            {
                int temp = height;
                height = width % height;
                width = temp;
            }
            return width;
        }
    }
}