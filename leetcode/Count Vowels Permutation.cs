namespace CSharpLeetcode.leetcode
{
    public class Count_Vowels_Permutation
    {
        public int CountVowelPermutation(int n)
        {
            var mod = (int)1e9 + 7;
            var dp = new long[5];
            for (int i = 0; i < 5; i++)
            {
                dp[i] = 1;
            }
            for (int i = 1; i < n; i++)
            {
                var nextDp = new long[5];
                nextDp[0] = (dp[1] + dp[2] + dp[4]) % mod;
                nextDp[1] = (dp[0] + dp[2]) % mod;
                nextDp[2] = (dp[1] + dp[3]) % mod;
                nextDp[3] = dp[2] % mod;
                nextDp[4] = (dp[2] + dp[3]) % mod;
                dp = nextDp;
            }
            return (int)(dp.Sum() % mod);
        }
    }
}