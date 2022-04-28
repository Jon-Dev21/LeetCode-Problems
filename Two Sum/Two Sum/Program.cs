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
                if(j < nums.Length)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j};
                    }  
                }
            }


            //if(i+1 < nums.Length) // Avoid out of bounds.
            //{
            //    if(nums[i] + nums[i+1] == target)
            //    {
            //        return new int[] { i, i + 1};
            //    }
            //} else if (nums[i] + nums[nums.Length-1] == target)
            //{
            //    return new int[] { i, nums.Length - 1 };
            //}
        }
        return new int[] {0,0};
    }
}