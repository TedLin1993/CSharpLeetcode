namespace CSharpLeetcode.leetcode;
public class Minimum_Cost_to_Make_Array_Equalindromic
{
    public long MinimumCost(int[] nums)
    {
        var n = nums.Length;
        if (n == 1) return 0;
        Array.Sort(nums);
        var mid = nums[n / 2];
        if (n % 2 == 0)
        {
            mid = (nums[n / 2 - 1] + nums[n / 2]) / 2;
        }
        var left = mid;
        while (left > 0)
        {
            if (isPalindromic(left)) break;
            left--;
        }
        var right = mid;
        while (true)
        {
            if (isPalindromic(right)) break;
            right++;
        }
        return Math.Min(cost(nums, left), cost(nums, right));

    }
    bool isPalindromic(int a)
    {
        var list = new List<int>();
        while (a > 0)
        {
            list.Add(a % 10);
            a /= 10;
        }
        var n = list.Count;
        for (int i = 0; i <= n / 2; i++)
        {
            if (list[i] != list[n - 1 - i]) return false;
        }
        return true;
    }
    long cost(int[] nums, int p)
    {
        long res = 0;
        foreach (var v in nums)
        {
            res += Math.Abs(v - p);
        }
        return res;
    }
}