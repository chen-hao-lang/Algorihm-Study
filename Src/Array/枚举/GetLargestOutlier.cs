namespace Alogorihm.Array.枚举
{
    class GetLargestOutlier
    {
        public int Solve(int[] nums)
        {
            IDictionary<int, int> counts = new Dictionary<int, int>();
            int total = 0;
            foreach (int num in nums)
            {
                counts.TryAdd(num, 0);
                counts[num]++;
                total += num;
            }
            int largestOutlier = int.MinValue;
            foreach (int num in nums)
            {
                if ((total - num) % 2 == 0)
                {
                    int sum = (total - num) / 2;
                    if (counts.ContainsKey(sum) && (sum != num || counts[num] > 1))
                    {
                        largestOutlier = System.Math.Max(largestOutlier, num);
                    }
                }
            }
            return largestOutlier;
        }
    }
}