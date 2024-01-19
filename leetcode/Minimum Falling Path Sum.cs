namespace CSharpLeetcode.leetcode;

public class _931
{
    public int MinFallingPathSum(int[][] matrix)
    {
        var n = matrix.Length;
        var dp = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            dp[n - 1, i] = matrix[n - 1][i];
        }
        for (int i = n - 2; i >= 0; i--)
        {
            dp[i, 0] = matrix[i][0] + Math.Min(dp[i + 1, 0], dp[i + 1, 1]);
            for (int j = 1; j < n - 1; j++)
            {
                dp[i, j] = matrix[i][j] + Math.Min(dp[i + 1, j - 1], Math.Min(dp[i + 1, j], dp[i + 1, j + 1]));
            }
            dp[i, n - 1] = matrix[i][n - 1] + Math.Min(dp[i + 1, n - 2], dp[i + 1, n - 1]);
        }
        var res = dp[0, 0];
        for (int i = 1; i < n; i++)
        {
            res = Math.Min(res, dp[0, i]);
        }
        return res;
    }
}