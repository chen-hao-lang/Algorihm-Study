using System.Runtime.InteropServices.Marshalling;

namespace Alogorihm.Array
{
    /// <summary>
    /// 重新排列数组
    /// </summary>
    class Shuffle
    {
        public int[] Slove1(int[] nums, int n)
        {
            int[] res = new int[n * 2];

            for (int i = 0; i < n; i++)
            {
                // 偶数位
                res[2 * i] = nums[i];
                // 奇数位
                res[2 * i + 1] = nums[i + n];
            }
            return res;
        }
    }
}