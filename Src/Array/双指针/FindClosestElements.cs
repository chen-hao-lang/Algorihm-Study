using System;

namespace Alogorihm.Array.双指针
{
    /// <summary>
    /// 658.找到K个最接近的元素
    /// https://leetcode.cn/problems/find-k-closest-elements/
    /// </summary>
    class FindClosestElements
    {
        public IList<int> Solve2(int[] arr,int k,int x)
        {
            List<int> ans = new List<int>();
            int left = 0;
            int right = arr.Length - 1;

            // 需要删除的元素数量：数组总长度 - k
            int deleteCount = arr.Length - k;
            while (deleteCount > 0)
            {
                // 比较两端元素到x的距离，删除更远的一边
                int distLeft = System.Math.Abs(arr[left] - x);
                int distRight = System.Math.Abs(arr[right] - x);

                left += distLeft > distRight ? 1 : 0;// 如果左边距离更长，删除左边
                right -= distRight > distLeft ? 1 : 0;// 如果右边距离更长，删除右边

                // 如果左右两边距离相等，删除右边
                if (distLeft == distRight && left < right)
                {
                    right--;
                }

                deleteCount--;
            }

            // 收集剩余的K个连续元素
            for (int i = left; i <= right; i++)
            {
                ans.Add(arr[i]);
            }

            return ans;
        }
    }
}