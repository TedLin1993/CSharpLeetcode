namespace CSharpLeetcode.leetcode;
class q7
{
    public static int SelectStock(int saving, List<int> currentValue, List<int> futureValue)
    {
        int n = currentValue.Count;
        int[,] dp = new int[n + 1, saving + 1];

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j <= saving; j++)
            {
                dp[i, j] = dp[i - 1, j];
                if (j >= currentValue[i - 1])
                {
                    dp[i, j] = Math.Max(dp[i, j], dp[i - 1, j - currentValue[i - 1]] + futureValue[i - 1]);
                }
            }
        }

        return dp[n, saving];
    }

    public void Test()
    {
        int saving = 250;
        List<int> currentValue = [175, 133, 109, 210, 97];
        List<int> futureValue = [200, 125, 128, 228, 133];

        int result = SelectStock(saving, currentValue, futureValue); //55
        Console.WriteLine(result);
    }

}