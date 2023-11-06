namespace CSharpLeetcode.leetcode;

public class Maximum_Balanced_Subsequence_Sum
{
    public long MaxBalancedSubsequenceSum(int[] nums)
    {
        var n = nums.Length;
        var memo = new long[n, 2];
        var limit = (long)-1e9 - 1;
        for (int i = 0; i < n; i++)
        {
            memo[i, 0] = limit;
            memo[i, 1] = limit;
        }
        long dfs(int idx, int preIdx)
        {
            if (idx == n) return 0;

            long res1 = limit;
            if (preIdx == -1 || nums[idx] - nums[preIdx] >= idx - preIdx)
            {
                if (memo[idx, 1] != limit)
                {
                    res1 = memo[idx, 1];
                }
                else
                {
                    res1 = nums[idx] + dfs(idx + 1, idx);
                    memo[idx, 1] = res1;
                }
            }
            long res2 = limit;
            if (idx == n - 1 && preIdx == -1)
            {
                res2 = limit;
            }
            else if (memo[idx, 0] != limit)
            {
                res2 = memo[idx, 0];
            }
            else
            {
                res2 = dfs(idx + 1, preIdx);
                memo[idx, 0] = res2;
            }
            return Math.Max(res1, res2);
        }
        var res = dfs(0, -1);
        return res;
    }
    public void Test()
    {
        // Console.WriteLine(MaxBalancedSubsequenceSum(new int[] { -2, -1 })); //-1
        Console.WriteLine(MaxBalancedSubsequenceSum(new int[] { -9, -6, -5 })); //-5
    }
}