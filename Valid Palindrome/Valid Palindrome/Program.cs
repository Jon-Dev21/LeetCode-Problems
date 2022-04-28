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
        string temp = "";
        string temp2 = "";
        s = s.ToLower().Trim();
        for(int i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                temp = s[i] + temp; // Reversed trimmed and lower case string
                temp2 += s[i]; // Original trimmed and lower case string
            }
        }
        return temp == temp2;
    }
}