internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsAnagram("aacc", "ccac"));
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
            for (int i = 0; i < t.Length; i++)
            {
                if(!s.Contains(t[i]))
                    return false;
                else
                {
                    int pos = s.IndexOf(t[i]);
                    equalLetters++;
                    s = s.Substring(0, pos) +s.Substring(pos+1);
                }
                    
            }
            return (equalLetters == t.Length ? true : false);
        }
            
    }
}


