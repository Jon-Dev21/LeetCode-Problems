internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsAnagram("a", "ab"));
        Console.WriteLine(IsAnagram("rat", "car"));
        Console.WriteLine(IsAnagram("rat", "tar"));
        Console.WriteLine(IsAnagram("anagram", "margana"));
        Console.WriteLine(IsAnagram("anagram", "nagaram"));
    }

    public static bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
        {
            return false;
        } 
        else
        {
            int equalLetters = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == t[j])
                    {
                        equalLetters++;
                        break;
                    }
                }
            }
            return (equalLetters == s.Length ? true : false);
        }
            
    }
}


