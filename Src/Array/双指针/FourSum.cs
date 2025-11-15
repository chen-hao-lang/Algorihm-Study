using Alogorihm.Array.不定长滑动窗口;

namespace Alogorihm.Array.双指针
{
    class FourSum
    {
        public IList<IList<int>> Solve(int[] nums, int target)
        {
            System.Array.Sort(nums);
            List<IList<int>> ans = new List<IList<int>>();
            int n = nums.Length;
            //int a = 0, b = 1;

            for (int a = 0; a < n - 3; a++)
            {
                long x = nums[a];
                if (a > 0 && nums[a] == nums[a - 1]) continue;
                if (x + nums[a + 1] + nums[a + 2] + nums[a + 3] > target) break;
                if (x + nums[n - 3] + nums[n - 2] + nums[n - 1] < target) continue;

                for (int b = a + 1; b < n - 2; b++)
                {
                    long y = nums[b];

                    if (b > a + 1 && y == nums[b - 1]) continue;
                    if (x + y + nums[b + 1] + nums[b + 2] > target) break;
                    if (x + y + nums[n - 2] + nums[n - 1] < target) continue;

                    int c = b + 1;
                    int d = n - 1;

                    while (c < d)
                    {
                        long s = x + y + nums[c] + nums[d];
                        if (s > target) d--;
                        else if (s < target) c++;
                        else
                        {
                            ans.Add(new List<int>() { (int)x, (int)y, nums[c], nums[d] });
                            for (c++; c < d && nums[c] == nums[c - 1]; c++) ;
                            for (d--; d > c && nums[d] == nums[d + 1]; d--) ;
                        }
                    }
                }
            }

            return ans;
        }
    }
}