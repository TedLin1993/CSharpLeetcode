namespace CSharpLeetcode.leetcode;

public class _713
{
    public int NumSubarrayProductLessThanK(int[] nums, int k)
    {
        if (k <= 1) return 0;
        long prod = 1;
        var left = 0;
        var res = 0;
        for (var right = 0; right < nums.Length; right++)
        {
            prod *= nums[right];
            while (prod >= k && left < right)
            {
                prod /= nums[left];
                left++;
            }
            if (prod < k)
            {
                res += right - left + 1;
            }
        }
        return res;
    }
}