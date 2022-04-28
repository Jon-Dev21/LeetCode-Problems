internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        Console.WriteLine(IsPalindrome("race a car"));
        Console.WriteLine(IsPalindrome("0P"));
    }

    public static bool IsPalindrome(string s)
    {
        string reversed = "";
        string straight = "";
        string dbReverse = "";
        s = s.ToLower().Trim();
        for(int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                reversed = s[i] + reversed; // Reversed trimmed and lower case string
                straight += s[i]; // Original trimmed and lower case string
                dbReverse += reversed;
            }
        }
        return reversed == straight || dbReverse == straight;
    }
}