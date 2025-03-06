namespace CSharpLeetcode.leetcode;

public class _2915
{
    public int LengthOfLongestSubsequence(IList<int> nums, int target)
    {
        var n = nums.Count;
        var dp = new int[target + 1];
        Array.Fill(dp, -1);
        dp[0] = 0;

        foreach (var num in nums)
        {
            for (int i = target - num; i >= 0; i--)
            {
                if (dp[i] == -1) continue;
                dp[i + num] = Math.Max(dp[i + num], dp[i] + 1);
            }
        }

        return dp[target];
    }
}