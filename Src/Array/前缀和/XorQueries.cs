namespace Alogorihm.Array.前缀和
{
    /// <summary>
    /// 子数组异或查询
    /// https://leetcode.cn/problems/xor-queries-of-a-subarray/description/
    /// </summary>
    class XorQueries
    {
        public int[] Solve(int[] arr, int[][] queries)
        {
            int n = arr.Length;
            int[] prefixXors = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                prefixXors[i + 1] = prefixXors[i] ^ arr[i];
            }

            int queriesCount = queries.Length;
            int[] answer = new int[queriesCount];
            for (int i = 0; i < queriesCount; i++)
            {
                int left = queries[i][0];
                int right = queries[i][1];
                answer[i] = prefixXors[right + 1] ^ prefixXors[left];
            }

            return answer;
        }
    }
}