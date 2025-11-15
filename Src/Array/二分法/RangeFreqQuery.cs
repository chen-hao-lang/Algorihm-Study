namespace Alogorihm.Array.二分法
{
    class RangeFreqQuery
    {
        // 为什么使用Dictionary<int, List<int>> 而不是 Dictionary<int, int>
        // 因为我们需要记录每个值在数组中出现的所有索引位置，以便后续进行范围查询
        // 例如，值 5 在数组中可能出现多次，我们需要知道它们分别出现在什么位置
        // 这样在查询时，我们可以通过二分查找快速定位某个值在指定范围内的出现次数
        private readonly Dictionary<int, List<int>> _valueIndices = new();
        public RangeFreqQuery(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                if (!_valueIndices.ContainsKey(num))
                {
                    _valueIndices[num] = new List<int>();
                }
                _valueIndices[num].Add(i);
            }
        }

        public int Query(int left, int right, int value)
        {
            if (!_valueIndices.TryGetValue(value, out List<int> indices))
            {
                return 0;
            }

            int leftIdx = FindFirstGreaterEqual(indices, left);
            int rightIdx = FindLastLessOrEqual(indices, right);

            return leftIdx > rightIdx ? 0: rightIdx - leftIdx + 1;  
        }

        private int FindLastLessOrEqual(List<int> indices, int target)
        {
            int l = 0, r = indices.Count - 1;
            int result = indices.Count;
            while (l <= r)
            {
                int mid = (r + l) >>> 1;
                if (indices[mid] >= target)
                {
                    result = mid;
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return result;
        }

        private int FindFirstGreaterEqual(List<int> indices, int target)
        {
            int l = 0, r = indices.Count - 1;
            int result = -1; // 默认返回 -1（无满足条件元素）
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (indices[mid] <= target)
                {
                    result = mid; // 记录可能的右边界
                    l = mid + 1; // 向右收缩，找更大的满足条件的索引
                }
                else
                {
                    r = mid - 1; // 向左收缩
                }
            }
            return result;
        }
    }
}