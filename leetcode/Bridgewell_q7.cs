namespace CSharpLeetcode.leetcode;
class q7
{
    public static int SelectStock(int saving, List<int> currentValue, List<int> futureValue)
    {
        int n = currentValue.Count;
        int[] dp = new int[saving + 1];

        for (int i = 0; i < n; i++)
        {
            for (int j = saving; j >= currentValue[i]; j--)
            {
                dp[j] = Math.Max(dp[j], dp[j - currentValue[i]] + futureValue[i] - currentValue[i]);
            }
        }

        return dp[saving];
    }

    public void Test()
    {
        int saving = 250;
        List<int> currentValue = [175, 133, 109, 210, 97];
        List<int> futureValue = [200, 125, 128, 228, 133];
        // choose index 2 and 4
        int result = SelectStock(saving, currentValue, futureValue); //55
        Console.WriteLine(result);
    }

}