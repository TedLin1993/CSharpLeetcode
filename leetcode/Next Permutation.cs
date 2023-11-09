namespace CSharpLeetcode.leetcode;
public class Next_Permutation
{
    public void NextPermutation(int[] nums)
    {
        var n = nums.Length;
        var idx = -1;
        for (int i = n - 1; i > 0; i--)
        {
            if (nums[i] > nums[i - 1])
            {
                idx = i - 1;
                break;
            }
        }
        if (idx == -1)
        {
            Array.Sort(nums);
            return;
        }
        var changeIdx = idx + 1;
        for (int i = idx + 1; i < n; i++)
        {
            if (nums[i] > nums[idx] && nums[i] < nums[changeIdx])
            {
                changeIdx = i;
            }
        }
        (nums[idx], nums[changeIdx]) = (nums[changeIdx], nums[idx]);
        Array.Sort(nums, idx + 1, n - idx - 1);
    }
    public void Test()
    {
        NextPermutation(new int[] { 2, 3, 1 });
    }
}