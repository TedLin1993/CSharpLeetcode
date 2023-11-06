namespace CSharpLeetcode.leetcode;
public class Number_of_Longest_Increasing_Subsequence
{
    public int FindNumberOfLIS(int[] nums)
    {
        var n = nums.Length;
        var dp = new List<(int len, int count)>();
        for (int i = 0; i < n; i++)
        {
            dp.Add((1, 1));
        }
        var maxLen = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (nums[i] > nums[j])
                {
                    if (dp[i].len <= dp[j].len)
                    {
                        dp[i] = (dp[j].len + 1, dp[j].count);
                    }
                    else if (dp[i].len - 1 == dp[j].len)
                    {
                        dp[i] = (dp[i].len, dp[i].count + dp[j].count);
                    }
                }
            }
            maxLen = Math.Max(maxLen, dp[i].len);
        }
        var res = 0;
        foreach (var (len, count) in dp)
        {
            if (len == maxLen) res += count;
        }
        return res;
    }
}