namespace Alogorihm.Array.枚举
{
    /// <summary>
    /// 数位和相等数对的最大和
    /// https://leetcode.cn/problems/max-sum-of-a-pair-with-equal-sum-of-digits/description/
    /// </summary>
    class MaximumSum
    {
        public int Solve(int[] nums)
        {
            // 判断两个数字的数位和是否相等
            // 如果相等，与上一个数位和的数字比较大小
            // 返回最大的数位和相等的数字和
            int maxNum = -1;
            Dictionary<int, int> map = new();

            foreach (var num in nums)
            {
                int temp = 0;
                for (int i = num; i > 0; i /= 10)
                {
                    temp += i % 10;
                }

                if (map.ContainsKey(temp))
                {
                    maxNum = System.Math.Max(maxNum, num + map[temp]);
                    map[temp] = System.Math.Max(map[temp], num);
                }
                else
                {
                    map[temp] = num;
                }
            }
            return maxNum;
        }

        public int Solve2(int[] nums)
        {
            int maxNum = -1;
            int[] map = new int[82];

            foreach (var num in nums)
            {
                int temp = 0;
                for (int i = num; i > 0; i /= 10)
                {
                    temp += i % 10;
                }

                if(map[temp] >0)
                {
                    maxNum = System.Math.Max(maxNum,num + map[temp]);
                }

                map[temp] = System.Math.Max(map[temp],num);
            }
            return maxNum;
        }
    }
}