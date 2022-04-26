public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> unique = new HashSet<int>(nums.Length);
        foreach (int num in nums)
        {
            if(!unique.Add(num))
                return true;
        }
        return false;
    }
}