namespace Alogorihm.Array.前缀和
{
    class CountOdds
    {
        public int Solve1(int low, int high)
        {
            int ans = 0;

            for (int i = low; i <= high; i++)
            {
                if (i % 2 != 0)
                {
                    ans++;
                }
            }
            return ans;
        }

        public int Solve2(int low, int high)
        {
            bool lowOdd = low % 2 != 0;
            bool highOdd = high % 2 != 0;

            // 均为奇数
            if (lowOdd && highOdd)
            {
                return (high - low + 1) / 2 + 1;
            }
            else//均为偶数、一偶一奇
            {
                return (high - low + 1) / 2;
            }
           
        }
    }
}