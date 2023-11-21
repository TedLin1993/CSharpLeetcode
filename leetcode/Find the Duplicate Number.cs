namespace CSharpLeetcode.leetcode;

public class Find_the_Duplicate_Number
{
    public int FindDuplicate_BS(int[] nums)
    {
        var n = nums.Length;
        var left = 1;
        var right = n - 1;
        while (left < right)
        {
            var mid = left + (right - left + 1) / 2;
            var count = 0;
            foreach (var num in nums)
            {
                if (num >= mid)
                {
                    count++;
                }
            }
            if (count > n - mid)
            {
                left = mid;
            }
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }
    public int FindDuplicate(int[] nums)
    {
        var slow = nums[0];
        var fast = nums[nums[0]];
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        fast = 0;
        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }
        return slow;
    }
}