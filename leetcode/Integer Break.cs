namespace CSharpLeetcode.leetcode
{
    public class Integer_Break
    {
        public int IntegerBreak(int n)
        {
            if (n < 4) return n - 1;
            var dp = new int[n + 1];
            dp[2] = 2;
            dp[3] = 3;
            for (int i = 4; i <= n; i++)
            {
                for (int j = 1; i - j >= 2; j++)
                {
                    dp[i] = Math.Max(dp[i], dp[i - j] * dp[j]);
                }
            }
            return dp[n];
        }
    }
}