namespace CSharpLeetcode.leetcode;

public class _368
{
    public IList<int> LargestDivisibleSubset(int[] nums)
    {
        var n = nums.Length;
        Array.Sort(nums);
        var dp = new int[n];
        for (int i = 0; i < n; i++) dp[i] = 1;
        var prev = new int[n];
        var idx = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i - 1; j >= 0; j--)
            {
                if (nums[i] % nums[j] == 0 && dp[i] <= dp[j])
                {
                    dp[i] = dp[j] + 1;
                    prev[i] = j;
                }
            }
            if (dp[i] > dp[idx])
            {
                idx = i;
            }
        }

        List<int> res = [];
        var count = dp[idx];
        for (int i = 0; i < count; i++)
        {
            res.Add(nums[idx]);
            idx = prev[idx];
        }
        return res;
    }
}