namespace CSharpLeetcode.leetcode;

public class _3350
{
    public int MaxIncreasingSubarrays(IList<int> nums)
    {
        var n = nums.Count;

        var preSum = new int[n];
        preSum[0] = 1;
        for (int i = 1; i < n; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                preSum[i] = preSum[i - 1] + 1;
            }
            else
            {
                preSum[i] = 1;
            }
        }

        var suffixSum = new int[n];
        suffixSum[n - 1] = 1;
        for (int i = n - 2; i >= 0; i--)
        {
            if (nums[i] < nums[i + 1])
            {
                suffixSum[i] = suffixSum[i + 1] + 1;
            }
            else
            {
                suffixSum[i] = 1;
            }
        }

        var res = 1;
        for (int i = 1; i < n; i++)
        {
            res = Math.Max(res, Math.Min(preSum[i - 1], suffixSum[i]));
        }
        return res;
    }
}