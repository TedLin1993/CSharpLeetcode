namespace CSharpLeetcode.leetcode;

public class _3019
{
    public int CountKeyChanges(string s)
    {
        var diff = 'A' - 'a';
        var res = 0;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] + diff != s[i - 1] && s[i] - diff != s[i - 1] && s[i] != s[i - 1]) res++;
        }
        return res;
    }
}