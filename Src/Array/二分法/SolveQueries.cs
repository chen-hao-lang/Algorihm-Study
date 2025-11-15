namespace Alogorihm.Array.二分法
{
    /// <summary>
    /// 3488.距离最小相等元素查询
    /// https://leetcode.cn/problems/closest-equal-element-queries/
    /// </summary>
    class SolveQueries
    {
        public IList<int> Solve(int[] nums, int[] queries)
        {
            Dictionary<int, List<int>> indices = new();
            int n = nums.Length;

            // 遍历数组 nums 得到每个元素的升序下标列表并使用哈希表存储
            for (int i = 0; i < nums.Length; i++)
            {
                if (!indices.ContainsKey(nums[i]))
                {
                    indices[nums[i]] = new List<int>();
                }
                indices[nums[i]].Add(i);
            }

            foreach (var pair in indices)
            {
                IList<int> idx = pair.Value;
                int firstIndex = idx[0], lastIndex = idx[idx.Count - 1];
                if (firstIndex != lastIndex)// 保证有重复元素
                {
                    idx.Insert(0, lastIndex - n);// 在开头添加虚拟下标
                    idx.Add(firstIndex + n);// 在结尾处添加虚拟下标
                }
            }

            IList<int> answer = new List<int>();
            foreach (var query in queries)
            {
                // 获取当前元素的下标列表
                IList<int> idx = indices[nums[query]];
                int size = idx.Count;
                if (size > 1)// 有重复元素
                {
                    // 使用二分查找定位 query 在 idx 列表中的位置
                    int pos = BinarySearch(idx, query);
                    int distanceLeft = idx[pos] - idx[pos - 1];
                    int distanceRight = idx[pos + 1] - idx[pos];
                    answer.Add(System.Math.Min(distanceLeft, distanceRight));
                }
                else// 没有重复元素
                {
                    answer.Add(-1);
                }
            }

            return answer;
        }

        public int BinarySearch(IList<int> indices, int target)
        {
            int low = 0, high = indices.Count - 1;
            while (low <= high)
            {
                int mid = (low + high) >>> 1;

                if (indices[mid] == target)
                {
                    return mid;
                }
                else if (indices[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1;
        }
    }
}