internal class Program
{
    static void Main(string[] args)
    {
        var watch = new System.Diagnostics.Stopwatch();

        watch.Start();
        Console.WriteLine(IsAnagram("aacc", "ccac"));
        //Console.WriteLine(IsAnagram("a", "ab"));
        //Console.WriteLine(IsAnagram("rat", "car"));
        //Console.WriteLine(IsAnagram("rat", "tar"));
        //Console.WriteLine(IsAnagram("anagram", "margana"));
        //Console.WriteLine(IsAnagram("anagram", "nagaram"));

        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
    }

    public static bool IsAnagram(string s, string t)
    {
        var a = s.ToArray();
        var b = t.ToArray();
        Array.Sort(a);
        Array.Sort(b);
        return new string(a) == new string(b);
    }

    /***
     * This solution runs at 3ms with this test.
     * Console.WriteLine(IsAnagram("aacc", "ccac"));
     * 
     * 
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        else
        {
            int equalLetters = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (s.IndexOf(t[i]) == -1)
                    return false;
                else
                {
                    int pos = s.IndexOf(t[i]);
                    equalLetters++;
                    s = s.Substring(0, pos) + s.Substring(pos + 1);
                }

            }
            return (equalLetters == t.Length ? true : false);
        }
    }*/

    /**
     * This method works but it's too slow.
     * Was not submitted due to too much time. 7ms
     * Console.WriteLine(IsAnagram("aacc", "ccac"));
     * 

    public static bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
        {
            return false;
        } 
        else
        {
            sbyte cnt;
            Dictionary<char, sbyte> HashMap_S = new Dictionary<char, sbyte>();
            sbyte cnt2;
            Dictionary<char, sbyte> HashMap_T = new Dictionary<char, sbyte>();
            for (int i = 0; i < t.Length; i++)
            {
                cnt = (sbyte)s.Count(f => (f == s[i]));
                if(cnt == 0)
                    return false;
                else if(!HashMap_S.ContainsKey(s[i]))
                    HashMap_S.Add(s[i], cnt);

                cnt2 = (sbyte)t.Count(f => (f == s[i]));
                if (cnt == 0)
                    return false;
                else if (!HashMap_T.ContainsKey(s[i]))
                    HashMap_T.Add(s[i], cnt2);

                if(HashMap_S[s[i]] != HashMap_T[s[i]])
                    return false;
            }
            return true;
        }
    }*/
}


