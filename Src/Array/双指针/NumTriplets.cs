namespace Alogorihm.Array.双指针
{
    /// <summary>
    /// 1577.数的平分等于两数乘积的平分
    /// https://leetcode.cn/problems/number-of-ways-where-square-of-number-is-equal-to-product-of-two-numbers/
    /// </summary>
    class NumTriplets
    {
        public int Solve(int[] nums1, int[] nums2)
        {
            System.Array.Sort(nums1);
            System.Array.Sort(nums2);

            int ans = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                int x = nums1[i];

                int j = 0;
                int k = nums2.Length - 1;

                while (j < k)
                {
                    if (x * x == nums2[j] * nums2[k])
                    {
                        ans++;
                    }
                    else if (x * x > nums2[j] * nums2[k])
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                int x = nums2[i];

                int j = 0;
                int k = nums1.Length - 1;

                while (j < k)
                {
                    if (x * x == nums1[j] * nums1[k])
                    {
                        ans++;
                    }
                    else if (x * x > nums1[j] * nums1[k])
                    {
                        k--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }

            return ans;
        }

        public int Solve2(int[] nums1, int[] nums2)
        {
            System.Array.Sort(nums1);
            System.Array.Sort(nums2);
            int ans = 0;

            // 第一部分：nums1[i]² 匹配 nums2 中的数对
            ans += CountMatches(nums1, nums2);
            // 第二部分：nums2[i]² 匹配 nums1 中的数对
            ans += CountMatches(nums2, nums1);

            return ans;
        }

        private int CountMatches(int[] numsA, int[] numsB)
        {
            int count = 0;
            foreach (int a in numsA)
            {
                long target = (long)a * a;
                int left = 0, right = numsB.Length - 1;
                while (left < right)
                {
                    long product = (long)numsB[left] * numsB[right];
                    if (product == target)
                    {
                        if (numsB[left] == numsB[right])
                        {
                            // 重复元素组合数：C(n,2) = n*(n-1)/2
                            int len = right - left + 1;
                            count += len * (len - 1) / 2;
                            break; // 整个区间处理完，跳出循环
                        }
                        else
                        {
                            // 统计左侧重复次数
                            int l = left;
                            int leftCount = 0;
                            while (l < numsB.Length && numsB[l] == numsB[left])
                            {
                                leftCount++;
                                l++;
                            }
                            // 统计右侧重复次数
                            int r = right;
                            int rightCount = 0;
                            while (r >= 0 && numsB[r] == numsB[right])
                            {
                                rightCount++;
                                r--;
                            }
                            // 累加组合数，跳步到重复区间外
                            count += leftCount * rightCount;
                            left = l;
                            right = r;
                        }
                    }
                    else if (product < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
            return count;
        }
    }
}