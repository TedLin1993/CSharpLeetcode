namespace CSharpLeetcode.leetcode;

public class _2971
{
    public long LargestPerimeter(int[] nums)
    {
        Array.Sort(nums);
        long sum = nums[0] + nums[1];
        long res = -1;
        for (int i = 2; i < nums.Length; i++)
        {
            if (sum > nums[i]) res = sum + nums[i];
            sum += nums[i];
        }
        return res;
    }
}