namespace Alogorihm.Array
{
    class MinArrivalsToDiscard
    {
        public int Solve(int[] arrivals, int m, int w)
        {
            int n = arrivals.Length;
            // 表示下标i的物品是否被丢弃
            bool[] discarded = new bool[n];
            // 记录在当前窗口内且被保留的物品的数量
            IDictionary<int, int> counts = new Dictionary<int, int>();
            int discardCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (i >= w && !discarded[i - w])
                {
                    counts[arrivals[i - w]]--;
                }

                counts.TryAdd(arrivals[i - w], 0);

                // 表示不丢弃下标 i 的元素时的以下标 i 结尾的长度不超过 w 的子数组中的 arrivals[i] 的出现次数
                // 如果不+1，判断当前的数量为m，<=m，然后哈希表就会+1，+1后就大于m了，m+1>m，则违反了约束
                int count = counts[arrivals[i]] + 1;

                if (count <= m)
                {
                    counts[arrivals[i]] = count;
                }
                else
                {
                    discardCount++;
                    discarded[i] = true;
                }
            }

            return discardCount;
        }
    }
}