namespace CSharpLeetcode.leetcode;

public class _3022
{
    public int MinOrAfterOperations(int[] nums, int k)
    {
        var res = 0;
        var mask = 0;
        for (int i = 29; i >= 0; i--)
        {
            mask |= 1 << i;
            var cur = mask;
            var count = 0;
            foreach (var num in nums)
            {
                cur &= num & mask;
                if (cur != 0)
                    count++;
                else
                    cur = mask;
            }
            if (count > k)
            {
                mask ^= 1 << i;
                res |= 1 << i;
            }
        }
        return res;
    }
}