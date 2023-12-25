namespace CSharpLeetcode.leetcode;

public class _221
{
    public int MaximalSquare(char[][] matrix)
    {
        int m = matrix.Length, n = matrix[0].Length;
        var dp = new int[m, n];
        var maxLen = 0;
        for (int i = 0; i < m; i++)
        {
            if (matrix[i][0] == '1')
            {
                dp[i, 0] = 1;
                maxLen = 1;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (matrix[0][i] == '1')
            {
                dp[0, i] = 1;
                maxLen = 1;
            }
        }
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (matrix[i][j] == '1')
                {
                    dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                    maxLen = Math.Max(maxLen, dp[i, j]);
                }
            }
        }
        return maxLen * maxLen;
    }
    public void Test()
    {
        MaximalSquare([['1', '0', '1', '0', '0'], ['1', '0', '1', '1', '1'], ['1', '1', '1', '1', '1'], ['1', '0', '0', '1', '0']]);
    }
}