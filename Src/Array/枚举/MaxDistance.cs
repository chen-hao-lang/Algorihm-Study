using System.Runtime.InteropServices.Marshalling;
using System.Text.Json.Serialization;

namespace Alogorihm.Array.枚举
{
    class MaxDistance
    {
        /// <summary>
        /// 暴力
        /// </summary>
        /// <param name="arrays"></param>
        /// <returns></returns>
        public int Solve(IList<IList<int>> arrays)
        {
            int res = 0;

            for (int i = 0; i < arrays.Count; i++)
            {
                for (int j = i + 1; j < arrays.Count; j++)
                {
                    for (int m = 0; m < arrays[i].Count; m++)
                    {
                        for (int n = 0; n < arrays[j].Count; n++)
                        {
                            int dis = System.Math.Abs(arrays[i][m] - arrays[j][n]);
                            res = System.Math.Max(res, dis);
                        }
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// 遍历数组，记录num【i】的首尾位置的值i1，i2；记录num【i+1】的首尾位置的值j1，j2
        /// 然后比较 j2-i1 与 i2-j1 的值哪个大
        /// </summary>
        /// <param name="arrays"></param>
        /// <returns></returns>
        public int Solve2(IList<IList<int>> arrays)
        {
            int res = int.MinValue;

            for (int i = 0; i < arrays.Count; i++)
            {
                for (int j = i + 1; j < arrays.Count; j++)
                {
                    int i1 = arrays[i][0];
                    int i2 = arrays[i][arrays[i].Count - 1];

                    int j1 = arrays[j][0];
                    int j2 = arrays[j][arrays[j].Count - 1];

                    int temp1 = System.Math.Abs(j2 - i1);
                    int temp2 = System.Math.Abs(i2 - j1);
                    res = System.Math.Max(res, temp1);
                    res = System.Math.Max(res, temp2);
                }
            }
            return res;
        }

        public int Solve3(IList<IList<int>> arrays)
        {
            int ans = 0;

            int min = int.MaxValue / 2;
            int max = int.MinValue / 2;

            foreach (var a in arrays)
            {
                int x = a[0];
                int y = a[a.Count - 1];
                ans = System.Math.Max(ans, System.Math.Max(y - min, max - x));
                min = System.Math.Min(min, x);
                max = System.Math.Max(max, y);
            }

            return ans;
        }
    }
}