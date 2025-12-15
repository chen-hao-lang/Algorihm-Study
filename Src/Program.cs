class Program
{
    static void Main(string[] args)
    {
        // MaxDistance distance = new MaxDistance();
        // IList<List<int>> array = new List<List<int>>(){new List<int>(){1,2,3},
        //         new List<int>(){4,5},
        // new List<int>(){1,2,3}};

        // Console.WriteLine(distance.Solve(array));
    }
}


public class NumArray
{
    int[] preSumArray;
    public NumArray(int[] nums)
    {
        preSumArray = new int[nums.Length + 1];
        for (int i = 0; i < nums.Length; i++)
        {
            preSumArray[i + 1] = preSumArray[i] + nums[i];
        }
    }

    public int SumRange(int left, int right)
    {
        return preSumArray[right + 1] - preSumArray[left];
    }
}