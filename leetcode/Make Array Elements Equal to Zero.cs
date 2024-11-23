namespace CSharpLeetcode.leetcode;

public class _3354
{
    public int CountValidSelections(int[] nums)
    {
        var sum = nums.Sum();
        var left = 0;
        var res = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                var right = sum - left;
                if (left == right) res += 2;
                else if (Math.Abs(left - right) == 1) res++;
            }
            else
            {
                left += nums[i];
            }
        }
        return res;
    }
}