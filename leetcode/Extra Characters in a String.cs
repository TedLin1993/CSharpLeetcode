namespace CSharpLeetcode.leetcode;

public class _2707
{
    public int MinExtraChar(string s, string[] dictionary)
    {
        var n = s.Length;
        var set = dictionary.ToHashSet();
        var dp = new int[n + 1];
        for (int len = 1; len <= n; len++)
        {
            dp[len] = dp[len - 1] + 1;
            for (int i = 0; i < len; i++)
            {
                if (set.Contains(s[i..len]))
                {
                    dp[len] = Math.Min(dp[len], dp[i]);
                }
            }
        }
        return dp[n];
    }
}