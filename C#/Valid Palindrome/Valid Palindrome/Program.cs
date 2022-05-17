internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        Console.WriteLine(IsPalindrome("race a car"));
        Console.WriteLine(IsPalindrome("0P"));
    }

    /// <summary>
    /// Will attempt to use stacks. 
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    public static bool IsPalindrome(string s)
    {
        s = s.ToLower();
        var stringArray = s.Split(" ");
        string reversed = "";
        string straight = string.Join("", stringArray);
        int length = straight.Length-1;
        string straightClean = "";

        for (int i = length, j = 0; i >= 0 && j < length+1; i--, j++)
        {
            if (char.IsLetterOrDigit(straight[i]))
            {
                reversed += straight[i];
            } 
            if(char.IsLetterOrDigit(straight[j]))
            {
                straightClean += straight[j];
            }
        }
        return reversed == straightClean;
    }
}

    // Not fast enough.
    //public static bool IsPalindrome(string s)
    //{
    //    string reversed = "";
    //    string straight = "";
    //    string dbReverse = "";
    //    s = s.ToLower().Trim();
    //    for (int i = 0; i < s.Length; i++)
    //    {
    //        if (char.IsLetterOrDigit(s[i]))
    //        {
    //            reversed = s[i] + reversed; // Reversed trimmed and lower case string
    //            straight += s[i]; // Original trimmed and lower case string
    //            dbReverse += reversed;
    //        }
    //    }
    //    return reversed == straight || dbReverse == straight;
    //}