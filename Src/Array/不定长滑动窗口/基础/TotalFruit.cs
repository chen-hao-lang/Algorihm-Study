namespace Alogorihm.Array
{
    /// <summary>
    /// 水果成篮
    /// </summary>
    class TotalFruit
    {
        public int Solve(int[] fruits)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int ans = 0;
            int left = 0;

            for (int right = 0; right < fruits.Length; right++)
            {
                map[fruits[right]] = map.TryGetValue(fruits[right], out int value) ? value + 1 : 1;

                while (map.Count > 2)
                {
                    if (map.ContainsKey(fruits[left]))
                    {
                        map[fruits[left]]--;

                        if (map[fruits[left]] == 0)
                        {
                            map.Remove(fruits[left]);
                        }
                    }

                    left++;
                }

                ans = System.Math.Max(ans, right - left + 1);
            }
            return ans;
        }
    }
}