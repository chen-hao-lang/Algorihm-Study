using System.Runtime.Serialization.Formatters;

namespace Alogorihm.Array
{
    public class RemoveElement
    {
        public int SolveTowPointers(int[] nums, int target)
        {
            int slow = 0;
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (fast != target)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
            }

            return slow;
        }
    }
}