namespace Alogorihm.Array.枚举
{
    class MaxSum()
    {
        public int Solve(int[] nums)
        {
            int res = -1;
            // 存储最大数位为0-9的nums[i]，例如121为num[1]，2为num[1]中最大的数位，则num[1]存放在maxVal[2]中
            int[] maxVal = new int[10];
            // 为数组赋值
            System.Array.Fill(maxVal, int.MinValue);

            foreach (var v in nums)
            {
                // 遍历nums，找到num[i]的最大数位
                int maxD = 0;
                for (int x = v; x > 0; x /= 10)
                {
                    maxD = System.Math.Max(maxD, x % 10);
                }

                res = System.Math.Max(res, v + maxVal[maxD]);
                maxVal[maxD] = System.Math.Max(maxVal[maxD], v);
            }
            return res;
        }
    }
}