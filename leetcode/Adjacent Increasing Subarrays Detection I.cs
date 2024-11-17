namespace CSharpLeetcode.leetcode;

public class _3349
{
    public bool HasIncreasingSubarrays(IList<int> nums, int k)
    {
        var n = nums.Count;
        for (int i = 0; i + 2 * k - 1 < n; i++)
        {
            if (IsIncreasing(nums, i, k) && IsIncreasing(nums, i + k, k))
            {
                return true;
            }
        }

        return false;
    }
    public bool IsIncreasing(IList<int> nums, int index, int k)
    {
        for (int i = index + 1; i < index + k; i++)
        {
            if (nums[i] <= nums[i - 1]) return false;
        }
        return true;
    }
}