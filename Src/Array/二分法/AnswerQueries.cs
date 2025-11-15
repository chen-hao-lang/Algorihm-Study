using System;
using System.ComponentModel;

namespace Alogorihm.Array.二分法
{
    class AnswerQueries
    {
        public int[] Solve(int[] nums, int[] queries)
        {
            System.Array.Sort(nums);

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] += nums[i - 1];
            }

            for (int i = 0; i < queries.Length; i++)
            {
                queries[i] = System.Array.BinarySearch(nums,queries[i]);
            }
            return queries;
        }

        private int GetNumSum(int[] nums,int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) >>> 1;
                if(nums[mid] > target)
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }
            }

            return right;
        }
    }
}