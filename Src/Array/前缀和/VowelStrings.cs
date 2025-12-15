using System.ComponentModel;
using System.Runtime.CompilerServices;
using Alogorihm.Math;

namespace Alogorihm.Array.前缀和
{
    class VowelStrings
    {
        public int[] Solve1(string[] words, int[][] queries)
        {
            bool[] wordss = new bool[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if (IsVowels(words[i][0]) && IsVowels(words[i][words[i].Length - 1]))
                {
                    wordss[i] = true;
                }
            }

            int n = queries.Length;
            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                int left = queries[i][0];
                int right = queries[i][1];

                for (int j = left; j <= right; j++)
                {
                    if (wordss[j])
                    {
                        ans[i]++;
                    }
                }
            }

            return ans;
        }

        public int[] Solve2(string[] words, int[][] queries)
        {
            // 先判断当前字符串数组中每个字符是否是符合条件的字符串，是则使用一个int【】 数组存储当前字符串位置为1
            int[] wordss = new int[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                if (IsVowels(words[i][0]) && IsVowels(words[i][words[i].Length - 1]))
                {
                    wordss[i] = 1;
                }
            }

            // 统计前缀和
            int[] preArray = new int[wordss.Length + 1];
            for (int i = 0; i < wordss.Length; i++)
            {
                preArray[i + 1] = preArray[i] + wordss[i];
            }

            int n = queries.Length;
            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                int left = queries[i][0];
                int right = queries[i][1];

                ans[i] += preArray[right + 1] - preArray[left];
            }

            return ans;
        }

        public int[] Solve3(string[] words, int[][] queries)
        {
            // 先判断当前字符串数组中每个字符是否是符合条件的字符串，是则使用一个int【】 数组存储当前字符串位置为1
            // int[] wordss = new int[words.Length];
            // for (int i = 0; i < words.Length; i++)
            // {
            //     if (IsVowels(words[i][0]) && IsVowels(words[i][words[i].Length - 1]))
            //     {
            //         wordss[i] = 1;
            //     }
            // }
            string aeiou = "aeiou";

            // 统计前缀和
            int[] preArray = new int[words.Length + 1];
            for (int i = 0; i < words.Length; i++)
            {
                preArray[i + 1] = preArray[i];
                //preArray[i + 1] = preArray[i] + wordss[i];
                if (aeiou.Contains(words[i][0]) && aeiou.Contains(words[i][words[i].Length - 1]))
                {
                    preArray[i + 1]++;
                }
            }

            int n = queries.Length;
            int[] ans = new int[n];
            for (int i = 0; i < n; i++)
            {
                int left = queries[i][0];
                int right = queries[i][1];

                ans[i] += preArray[right + 1] - preArray[left];
            }

            return ans;
        }

        public bool IsVowels(char word)
        {
            return word == 'a' || word == 'e' || word == 'i' || word == 'o' || word == 'u';
        }
    }
}