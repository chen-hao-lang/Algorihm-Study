namespace Alogorihm.Array
{
    /// <summary>
    /// 大小为K且平均值大于等于阈值的子数组数目
    /// 
    /// 题目描述：
    /// 给你一个整数数组 arr 和两个整数 k 和 threshold 。
    /// 请你返回长度为 k 且平均值大于等于 threshold 的子数组数目。
    /// 
    /// </summary>
    class NumOfSubarrays
    {
        public int Solve1(int[] arr, int k, int threshold)
        {
            int ans = 0, currentAveng = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                int left = i - k + 1;
                if (left < 0)
                    continue;

                currentAveng = sum / k;
                if (currentAveng >= threshold)
                {
                    ans++;
                }
                sum -= arr[left];
            }

            return ans;
        }

        public int Solve2(int[] arr, int k, int threshold)
        {
            int ans = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                int left = i - k + 1;
                if (left < 0)
                    continue;

                if (sum >= k * threshold)
                {
                    ans++;
                }
                sum -= arr[left];
            }

            return ans;
        }
    }
}