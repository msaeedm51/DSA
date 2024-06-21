
public class Anagram
{
    public static bool IsValid(string s, string t)
    {
        if (s.Length != t.Length) return false;
        if (s == t) return true;

        Dictionary<char, int> sDic = new Dictionary<char, int>();
        Dictionary<char, int> tDic = new Dictionary<char, int>();

        for (int j = 0; j < s.Length; j++)
        {
            sDic[s[j]] = 1 + (sDic.ContainsKey(s[j]) ? sDic[s[j]] : 0);
            tDic[t[j]] = 1 + (tDic.ContainsKey(t[j]) ? tDic[t[j]] : 0);
        }

        foreach (KeyValuePair<char, int> element in sDic)
        {
            if (element.Value != (tDic.ContainsKey(element.Key) ? tDic[element.Key] : 0))
            {
                return false;
            }
        }

        return true;
    }

     static void Main(string[] args)
    {
        Console.WriteLine(IsValid("anagram", "nagaram"));
        Console.WriteLine(IsValid("Test DSA", "Tesi DAS"));
    }
}

