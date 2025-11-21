namespace Alogorihm.Array.枚举
{
    class NumEquivDominoPairs
    {
        public int Solve(int[][] dominoes)
        {
            int res = 0;
            Dictionary<int, int> map = new();

            foreach (var dominoe in dominoes)
            {
                int value = dominoe[0] < dominoe[1] ? dominoe[1] * 10 + dominoe[0] : dominoe[0] * 10 + dominoe[1];
                if (map.ContainsKey(value))
                {
                    res += map[value];
                    map[value]++;
                }
                else
                {
                    map[value] = 1;
                }
            }
            return res;
        }

        public int Solve2(int[][] dominoes)
        {
            int res = 0;
            int[][] cnt = new int[10][];
            for (int i = 0; i < cnt.Length; i++)
            {
                cnt[i] = new int[10];
            }
            System.Array.Fill(cnt,new int[10]);
            foreach (int[] domino in dominoes)
            {
                int a = System.Math.Min(domino[0], domino[1]);
                int b = System.Math.Max(domino[0], domino[1]);
                res += cnt[a][b]++;
            }
            return res;
        }

        public int Solve3(int[][] dominoes)
        {
            int res = 0;

            Dictionary<int,int> map =new();

            foreach(var pair in dominoes)
            {
                // 注释部分错误：2+2 = 1+3 ,不同的多米诺骨牌对，可能有相同的 min + max，导致被当成同一类统计
                // int minValue = System.Math.Min(pair[0],pair[1]);
                // int maxValue = System.Math.Max(pair[0],pair[1]);
                //int currentPairSum = minValue + maxValue;
                int currentPairSum = pair[0]>pair[1] ? pair[0] * 10 + pair[1] : pair[0] + pair[1]*10;

                if(map.ContainsKey(currentPairSum))
                {
                    res += map[currentPairSum];
                    map[currentPairSum]+=1;
                }
                else
                {
                    map[currentPairSum] = 1;
                }
            }
            return res;
        }
    }
}