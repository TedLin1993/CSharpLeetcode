namespace CSharpLeetcode.leetcode;

public class _70
{
    public int ClimbStairs(int n)
    {
        if (n <= 2) return n;
        var dp1 = 1;
        var dp2 = 2;
        for (int i = 3; i <= n; i++)
        {
            (dp1, dp2) = (dp2, dp1 + dp2);
        }
        return dp2;
    }
}