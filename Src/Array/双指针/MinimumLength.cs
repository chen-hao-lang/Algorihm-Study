using System.Runtime.InteropServices.Marshalling;

namespace Alogorihm.Array.双指针
{
    /// <summary>
    /// 删除字符串两端相同字符后的最短长度
    /// https://leetcode.cn/problems/minimum-length-of-string-after-deleting-similar-ends/
    /// </summary>
    class MinimumLength
    {
        /// <summary>
        /// ERROR
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int Solve(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            char tempChar;

            while (left < right)
            {
                while (s[left] == s[right])
                {
                    tempChar = s[left];

                    left += s[left + 1] == tempChar ? 1 : 0;
                    right -= s[right - 1] == tempChar ? 1 : 0;
                }

                left++;
                right--;

                if (s[left] != s[right])
                {
                    return right - left + 1;
                }
            }

            return 0;
        }

        public int Slove2(string s)
        {
            int right = s.Length - 1;
            int left = 0;
            char temp;
            while (left < right && s[left] == s[right])
            {
                temp = s[left];

                while (left <= right && s[left] == temp)
                {
                    left++;
                }

                while (left <= right && s[right] == temp)
                {
                    right--;
                }
            }

            return right - left + 1;
        }
    }
}