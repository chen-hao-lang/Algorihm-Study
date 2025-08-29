using System.Security.Cryptography;

namespace Alogorihm.Array
{
    /// <summary>
    /// 有序数组的平方
    /// </summary>
    class SortedSquares
    {
        /// <summary>
        /// 双指针
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] SloveBy(int[] nums)
        {
            //定义两个指针，一个指向数组头部，一个指向数组尾部
            int left = 0;
            int right = nums.Length - 1;
            int[] res = new int[nums.Length];
            int pos = nums.Length - 1;
            //判断两个指针指向的数的平方大小，小的指针就往前/后，进/退一步
            //使用循环的话，头部指针不能超过尾部指针

            while (left <= right)
            {
                if (nums[left] * nums[left] < nums[right] * nums[right])
                {
                    res[pos--] = nums[right] * nums[right];
                    right--;
                }
                else
                {
                    res[pos--] = nums[left] * nums[left];
                    left++;
                }
            }

            return res;
        }

        //暴力解法
        public int[] SloveForce(int[] nums)
        {
            int[] res = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = nums[i] * nums[i];
            }

            System.Array.Sort(res);

            return res;
        }
    }
}
