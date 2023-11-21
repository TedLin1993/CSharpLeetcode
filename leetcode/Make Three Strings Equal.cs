namespace CSharpLeetcode.leetcode;
public class Make_Three_Strings_Equal
{
    public int FindMinimumOperations(string s1, string s2, string s3)
    {
        var minLen = Math.Min(s1.Length, Math.Min(s2.Length, s3.Length));
        var commonCount = 0;
        for (int i = 0; i < minLen; i++)
        {
            if (s1[i] != s2[i] || s2[i] != s3[i])
            {
                break;
            }
            commonCount = i + 1;
        }
        if (commonCount == 0) return -1;
        return s1.Length - commonCount + s2.Length - commonCount + s3.Length - commonCount;
    }
}