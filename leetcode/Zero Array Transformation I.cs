namespace CSharpLeetcode.leetcode;

public class _3355
{
    public bool IsZeroArray(int[] nums, int[][] queries)
    {
        var n = nums.Length;
        var diff = new int[n + 1];
        foreach (var q in queries)
        {
            diff[q[0]]++;
            diff[q[1] + 1]--;
        }

        var cur = 0;
        for (int i = 0; i < n; i++)
        {
            cur += diff[i];
            if (nums[i] > cur) return false;
        }
        return true;
    }
}