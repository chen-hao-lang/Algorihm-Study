namespace Alogorihm.Array.二分法
{
    /// <summary>
    /// 寻找比目标字母大的最小字母
    /// https://leetcode.cn/problems/find-smallest-letter-greater-than-target/
    /// </summary>
    class NextGreatestLetter
    {
        public char Solve(char[] letters, char target)
        {
            int left = 0;
            int right = letters.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (letters[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            
            return letters[left % letters.Length];
        }
    }
}