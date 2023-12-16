namespace CSharpLeetcode.leetcode;
public class Jump_Game
{
    public bool CanJump(int[] nums)
    {
        var n = nums.Length;
        var cur = 0;
        for (int i = 0; i < n; i++)
        {
            if (cur < i) return false;
            cur = Math.Max(cur, i + nums[i]);
            if (cur >= n - 1) return true;
        }
        return false;
    }
    public void Test()
    {
        Console.WriteLine(CanJump([2, 3, 1, 1, 4])); //true
    }
}