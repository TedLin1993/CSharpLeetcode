namespace CSharpLeetcode.leetcode;

public class Count_Subarrays_Where_Max_Element_Appears_at_Least_K_Times
{
    public long CountSubarrays(int[] nums, int k)
    {
        var max = nums.Max();
        var left = 0;
        var count = 0;
        long res = 0;
        foreach (var v in nums)
        {
            if (v == max) count++;
            while (count == k)
            {
                if (nums[left] == max) count--;
                left++;
            }
            res += left;
        }
        return res;
    }
}