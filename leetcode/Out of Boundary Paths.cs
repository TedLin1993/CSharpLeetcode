namespace CSharpLeetcode.leetcode;

public class _576
{
    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
    {
        if (maxMove == 0) return 0;
        var dp = new long[maxMove + 1][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new long[m * n];
        }
        for (int i = 0; i < m * n; i++)
        {
            var r = i / n;
            var c = i % n;
            if (r == 0) dp[1][i]++;
            if (r == m - 1) dp[1][i]++;
            if (c == 0) dp[1][i]++;
            if (c == n - 1) dp[1][i]++;
        }
        var mod = (int)1e9 + 7;
        for (int i = 2; i <= maxMove; i++)
        {
            for (int j = 0; j < m * n; j++)
            {
                dp[i][j] = dp[1][j];
                var r = j / n;
                var c = j % n;
                if (r > 0) dp[i][j] = (dp[i][j] + dp[i - 1][j - n]) % mod;
                if (r < m - 1) dp[i][j] = (dp[i][j] + dp[i - 1][j + n]) % mod;
                if (c > 0) dp[i][j] = (dp[i][j] + dp[i - 1][j - 1]) % mod;
                if (c < n - 1) dp[i][j] = (dp[i][j] + dp[i - 1][j + 1]) % mod;
            }
        }
        return (int)dp[maxMove][startRow * n + startColumn];
    }
}