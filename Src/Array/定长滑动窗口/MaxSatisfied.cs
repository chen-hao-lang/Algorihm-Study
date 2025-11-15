namespace Alogorihm.Array
{
    /// <summary>
    /// 爱生气的书店老板
    /// https://leetcode.cn/problems/grumpy-bookstore-owner/submissions/677959334/?envType=problem-list-v2&envId=smKmHnN4
    /// </summary>
    class MaxSatisfied
    {
        /// <summary>
        /// 方案可行，但是如果数据过多会引起超时
        /// </summary>
        /// <param name="customers"></param>
        /// <param name="grumpy"></param>
        /// <param name="minutes"></param>
        /// <returns></returns>
        public int Solve1(int[] customers, int[] grumpy, int minutes)
        {
            int ans = 0, sum = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                //sum += customers[i];

                int left = i - minutes + 1;
                if (left < 0)
                {
                    continue;
                }

                for (int j = 0; j < customers.Length; j++)
                {
                    if (j >= left && j <= i)
                    {
                        sum += customers[j];
                    }
                    else if (grumpy[j] != 1)
                    {
                        sum += customers[j];
                    }
                }
                ans = System.Math.Max(ans, sum);
                sum = 0;
                left++;
            }
            return ans;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customers"></param>
        /// <param name="grumpy"></param>
        /// <param name="minutes"></param>
        /// <returns></returns>
        public int Solve2(int[] customers, int[] grumpy, int minutes)
        {
            int s1 = 0;
            int s0 = 0;
            int maxS1 = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                if (grumpy[i] == 0)
                {
                    s0 += customers[i];
                }

                if (grumpy[i] == 1)
                {
                    s1 += customers[i];
                }

                int left = i - minutes + 1;
                if (left < 0)
                    continue;

                maxS1 = System.Math.Max(maxS1, s1);
                if (grumpy[left] == 1)
                {
                    s1 -= customers[left];
                }
            }
            return s0 + maxS1;
        }

        public int Solve3(int[] customers, int[] grumpy, int minutes)
        {
            // 设计思路：定义长度为 2 的数组s，其中：
            // s[0]：对应老板不生气（grumpy[i]=0）时的总顾客数（即 “基础满意顾客数”）；
            // s[1]：对应当前滑动窗口内，老板生气（grumpy[i]=1）时的顾客数（即 “当前窗口可挽回的顾客数”）。
            int[] s = new int[2];
            int maxS1 = 0;

            for (int i = 0; i < customers.Length; i++)
            {
                s[grumpy[i]] += customers[i];
                if (i < minutes - 1)
                    continue;
                maxS1 = System.Math.Max(maxS1, s[1]);
                s[1] -= grumpy[i - minutes + 1] > 0 ? customers[i - minutes + 1] : 0;
            }
            return s[0] + maxS1;
        }
    }
}