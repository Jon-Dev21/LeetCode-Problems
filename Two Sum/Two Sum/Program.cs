internal class Program
{
    static void main(string[] args)
    {
        Console.WriteLine(TwoSum(new int[] {3,2,3}, 6));
    }

    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for(int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j};
            }
        }
        return new int[] {0,0};
    }
}