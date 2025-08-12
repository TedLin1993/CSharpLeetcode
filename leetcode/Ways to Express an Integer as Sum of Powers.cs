namespace CSharpLeetcode.leetcode;

public class _2787
{
    public int NumberOfWays(int n, int x)
    {
        var dp = new long[n + 1];
        dp[0] = 1;
        for (int i = 1; i <= n; i++)
        {
            var value = (int)Math.Pow(i, x);
            if (value > n) break;

            for (int j = n; j >= value; j--)
            {
                dp[j] += dp[j - value];
            }
        }
        return (int)(dp[n] % 1000000007);
    }

    public void Test()
    {
        Console.WriteLine(NumberOfWays(4, 1));
    }
}