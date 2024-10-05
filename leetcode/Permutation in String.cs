namespace CSharpLeetcode.leetcode;
public class _567
{
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        var len = s1.Length;
        var s1Arr = new int['z' - 'a' + 1];
        var s2Arr = new int['z' - 'a' + 1];
        for (int i = 0; i < len; i++)
        {
            s1Arr[s1[i] - 'a']++;
            s2Arr[s2[i] - 'a']++;
        }
        if (s1Arr.SequenceEqual(s2Arr)) return true;

        for (int i = len; i < s2.Length; i++)
        {
            s2Arr[s2[i - len] - 'a']--;
            s2Arr[s2[i] - 'a']++;
            if (s1Arr.SequenceEqual(s2Arr)) return true;
        }
        return false;
    }
}