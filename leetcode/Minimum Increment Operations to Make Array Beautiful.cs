namespace CSharpLeetcode.leetcode
{
    public class Minimum_Increment_Operations_to_Make_Array_Beautiful
    {
        public long MinIncrementOperations(int[] nums, int k)
        {
            var n = nums.Length;
            var dp = new long[n, 3];
            dp[0, 0] = Math.Max(k - nums[0], 0);
            for (int i = 1; i < n; i++)
            {
                var incre = Math.Max(k - nums[i], 0);
                dp[i, 0] = dp[i - 1, 0] + incre;
                for (int j = 1; j < 3; j++)
                {
                    dp[i, 0] = Math.Min(dp[i, 0], dp[i - 1, j] + incre);
                    dp[i, j] = dp[i - 1, j - 1];
                }
            }
            return Math.Min(dp[n - 1, 0], Math.Min(dp[n - 1, 1], dp[n - 1, 2]));
        }
        public void Test()
        {
            var res = MinIncrementOperations(new int[] { 2, 3, 0, 0, 2 }, 4);
            Console.WriteLine(res); //3
        }
    }
}