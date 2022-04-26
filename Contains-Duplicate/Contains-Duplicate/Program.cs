public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        List<int> unique = new List<int>(nums.Length);


        foreach (int num in nums)
        {
            unique.Add(num);

        }
    }
}