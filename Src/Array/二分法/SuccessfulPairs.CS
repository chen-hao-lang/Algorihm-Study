namespace Alogorihm.Array.二分法
{
    /// <summary>
    /// 咒语和药水的成功对数
    /// https://leetcode.cn/problems/successful-pairs-of-spells-and-potions/
    /// </summary>
    class SuccessfulPairs
    {
        public int[] Solve(int[] spells, int[] potions, long success)
        {
            System.Array.Sort(potions);

            for (int i = 0; i < spells.Length; i++)
            {
                long target = (success + spells[i] - 1) / spells[i];
                int index = BinarySearch(potions, target);
                spells[i] = potions.Length - index;
            }

            return spells;
        }

        public int BinarySearch(int[] potions, double target)
        {
            int left = 0;
            int right = potions.Length - 1;

            while (left < right)
            {
                // int mid = left + (right - left) / 2;
                int mid = (left + right) >>> 1;
                int mid1 = (left + right) >> 1;
                if (potions[mid] < target)
                {
                    left = mid +1;
                }
                else
                {
                    right = mid;
                }
            }

            return left;
        }
    }
}