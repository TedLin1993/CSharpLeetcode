namespace CSharpLeetcode.leetcode;

public class _162
{
    public int FindPeakElement(int[] nums)
    {
        var left = -1;
        var right = nums.Length;
        while (left + 1 < right)
        {
            var mid = left + (right - left) / 2;
            if (mid > 0 && nums[mid] < nums[mid - 1])
            {
                right = mid;
            }
            else if (mid < nums.Length - 1 && nums[mid] < nums[mid + 1])
            {
                left = mid;
            }
            else
            {
                return mid;
            }
        }
        return right;
    }
}