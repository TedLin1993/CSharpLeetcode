namespace CSharpLeetcode.leetcode;
public class Minimum_Number_of_Coins_to_be_Added
{
    public int MinimumAddedCoins(int[] coins, int target)
    {
        Array.Sort(coins);
        var sum = 0;
        var res = 0;
        var idx = 0;
        while (sum < target)
        {
            var cur = sum + 1;
            while (idx < coins.Length && coins[idx] <= cur)
            {
                sum += coins[idx];
                idx++;
            }
            if (sum < cur)
            {
                sum += cur;
                res++;
            }
        }
        return res;
    }
    public void Test()
    {
        MinimumAddedCoins([1, 4, 10], 19); //2
    }
}