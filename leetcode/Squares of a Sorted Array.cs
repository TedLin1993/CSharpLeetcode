namespace CSharpLeetcode.leetcode;

public class _977
{
    public int[] SortedSquares(int[] nums)
    {
        var res = new List<int>();
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            if (Math.Abs(nums[left]) >= Math.Abs(nums[right]))
            {
                res.Add(nums[left] * nums[left]);
                left++;
            }
            else
            {
                res.Add(nums[right] * nums[right]);
                right--;
            }
        }
        res.Reverse();
        return res.ToArray();
    }
}