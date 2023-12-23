namespace CSharpLeetcode.leetcode;

public class _215
{
    Random rnd;
    public int FindKthLargest(int[] nums, int k)
    {
        rnd = new Random();
        var n = nums.Length;
        return quickSelect(nums, n - k, 0, n - 1);
    }
    int quickSelect(int[] nums, int targetIdx, int left, int right)
    {
        var pivotIdx = rnd.Next(left, right + 1);
        var pivot = nums[pivotIdx];
        (nums[pivotIdx], nums[right]) = (nums[right], nums[pivotIdx]);
        int i = left;
        for (int j = left; j < right; j++)
        {
            if (nums[j] < pivot)
            {
                (nums[i], nums[j]) = (nums[j], nums[i]);
                i++;
            }
        }
        (nums[i], nums[right]) = (nums[right], nums[i]);
        if (i == targetIdx)
        {
            return pivot;
        }
        else if (i < targetIdx)
        {
            return quickSelect(nums, targetIdx, i + 1, right);
        }
        else
        {
            return quickSelect(nums, targetIdx, left, i - 1);
        }
    }
}