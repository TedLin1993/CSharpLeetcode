namespace CSharpLeetcode.leetcode;

public class _1143
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        if (text1.Length < text2.Length)
        {
            (text1, text2) = (text2, text1);
        }
        var n = text2.Length;
        var dp = new int[n + 1];
        for (int i = 0; i < text1.Length; i++)
        {
            var temp = new int[n + 1];
            for (int j = 0; j < text2.Length; j++)
            {
                if (text1[i] == text2[j])
                {
                    temp[j + 1] = dp[j] + 1;
                }
                else
                {
                    temp[j + 1] = Math.Max(temp[j], dp[j + 1]);
                }
            }
            dp = temp;
        }
        return dp[n];
    }
}