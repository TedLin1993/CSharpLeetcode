namespace CSharpLeetcode.leetcode;
public class _330
{
    public int MinPatches(int[] nums, int n)
    {
        long cur = 1;
        var i = 0;
        var res = 0;
        while (cur <= n)
        {
            if (i < nums.Length && nums[i] <= cur)
            {
                cur += nums[i];
                i++;
            }
            else
            {
                cur *= 2;
                res++;
            }
        }
        return res;
    }

    public void Test()
    {
        Console.WriteLine(MinPatches([1, 2, 31, 33], 2147483647)); //28
    }
}