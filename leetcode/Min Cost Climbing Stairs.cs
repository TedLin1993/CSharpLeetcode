namespace CSharpLeetcode.leetcode
{
    public class Min_Cost_Climbing_Stairs
    {
        public int MinCostClimbingStairs(int[] cost)
        {
            var n = cost.Length;
            var dp = new int[n + 1];
            for (int i = 2; i <= n; i++)
            {
                dp[i] = int.MaxValue;
            }
            for (int i = 0; i < n; i++)
            {
                dp[i + 1] = Math.Min(dp[i + 1], dp[i] + cost[i]);
                if (i < n - 1)
                {
                    dp[i + 2] = Math.Min(dp[i + 2], dp[i] + cost[i]);
                }
            }
            return dp[n];
        }
    }
}