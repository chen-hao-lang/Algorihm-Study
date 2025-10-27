namespace Alogorihm.Array.双指针
{
    /// <summary>
    /// 125.验证回文串
    /// </summary>
    class IsPalindrome
    {
        public bool Solve(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                // 左指针跳过非字母数字字符
                while (left < right && !char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                // 右指针跳过非字母数字字符
                while (left < right && !char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                // 统一转为小写比较（忽略大小写）
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }

                // 指针继续移动
                left++;
                right--;
            }

            return true;
        }
    }
}