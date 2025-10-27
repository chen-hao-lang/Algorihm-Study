using System.Globalization;

namespace Alogorihm.Array.双指针
{
    /// <summary>
    /// 2105.给植物浇水||
    /// </summary>
    class MinimumRefill
    {
        public int Solve(int[] plants, int capacityA, int capacityB)
        {
            int alice = 0;
            int bob = plants.Length - 1;
            int aCount = capacityA, bCount = capacityB;
            int res = 0;

            while (alice <= bob)
            {
                if (aCount < plants[alice])
                {
                    res++;
                    aCount = capacityA;
                }

                aCount -= plants[alice++];

                if (bCount < plants[bob])
                {
                    res++;
                    bCount = capacityB;
                }

                bCount -= plants[bob--];
            }

            if (alice == bob && System.Math.Max(aCount, bCount) < plants[alice])
                res++;

            return res;
        }
    }
}