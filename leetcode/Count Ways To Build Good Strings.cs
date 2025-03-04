namespace CSharpLeetcode.leetcode;

public class _2466
{
    public int CountGoodStrings(int low, int high, int zero, int one)
    {
        var mod = (int)1e9 + 7;
        var dp = new long[high + 1];
        dp[zero]++;
        dp[one]++;
        long res = 0;
        for (int i = 1; i < high + 1; i++)
        {
            if (i >= zero)
            {
                dp[i] += dp[i - zero];
            }
            if (i >= one)
            {
                dp[i] += dp[i - one];
            }
            dp[i] %= mod;
            if (i >= low)
            {
                res += dp[i];
                res %= mod;
            }
        }
        return (int)res;
    }

    public void Test()
    {
        CountGoodStrings(3, 100, 1, 1);
    }
}