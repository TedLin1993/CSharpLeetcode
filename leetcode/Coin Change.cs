namespace CSharpLeetcode.leetcode
{
    public class Coin_Change
    {
        public int CoinChange(int[] coins, int amount)
        {
            var dp = new int[amount + 1];
            var maxVal = 10001;
            for (int i = 1; i < dp.Length; i++)
            {
                dp[i] = maxVal;
            }
            for (int i = 1; i <= amount; i++)
            {
                foreach (var coin in coins)
                {
                    if (i >= coin)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }
            if (dp[amount] == maxVal)
            {
                return -1;
            }
            return dp[amount];
        }
    }
}