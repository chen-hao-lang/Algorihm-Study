using System;

namespace Alogorihm.Array.双指针
{
    class ReverseVowels
    {
        public string Solve(string s)
        {
            char[] c = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;
            char temp;

            // 双指针循环：left < right时持续寻找元音对
            while (left < right)
            {
                // 左指针找到元音才停止移动
                while (left < right && !IsVowels(c[left]))
                {
                    left++;
                }
                // 右指针找到元音才停止移动
                while (left < right && !IsVowels(c[right]))
                {
                    right--;
                }

                // 交换两个元音
                temp = c[left];
                c[left] = c[right];
                c[right] = temp;

                // 交换后双指针同时移动，避免重复处理
                left++;
                right--;
            }

            return new string(c);
        }

        // 修正：包含大小写元音字母判断
        public bool IsVowels(char c)
        {
            c = char.ToLower(c); // 统一转为小写判断，简化逻辑
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}