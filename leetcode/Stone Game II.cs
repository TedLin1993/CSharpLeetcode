namespace CSharpLeetcode.leetcode;
public class _1140
{
    // TC: O(n^3)
    // SC: O(n^2)
    public int StoneGameII(int[] piles)
    {
        var n = piles.Length;
        var dp = new int[n][];
        for (var i = 0; i < n; i++)
        {
            dp[i] = new int[n + 1];
        }

        var suffixSum = new int[n];
        suffixSum[n - 1] = piles[n - 1];
        for (int i = n - 2; i >= 0; i--)
        {
            suffixSum[i] = suffixSum[i + 1] + piles[i];
        }

        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = n; j >= 1; j--)
            {
                if (i + 2 * j > n - 1)
                {
                    dp[i][j] = suffixSum[i];
                }
                else
                {
                    for (int k = 0; k < 2 * j; k++)
                    {
                        dp[i][j] = Math.Max(dp[i][j], suffixSum[i] - dp[i + k + 1][Math.Max(j, k + 1)]);
                    }
                }
            }
        }

        return dp[0][1];
    }
}