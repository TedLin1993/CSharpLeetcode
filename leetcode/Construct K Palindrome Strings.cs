namespace CSharpLeetcode.leetcode;

public class _1400
{
    public bool CanConstruct(string s, int k)
    {
        var len = s.Length;
        if (k > len) return false;
        var count = new int[26];
        for (int i = 0; i < len; i++)
        {
            count[s[i] - 'a']++;
        }
        var oddCount = 0;
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] % 2 == 1) oddCount++;
        }
        return oddCount <= k;
    }
}