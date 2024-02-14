namespace CSharpLeetcode.leetcode;

public class _2149
{
    public int[] RearrangeArray(int[] nums)
    {
        var posIdx = 0;
        var negIdx = 1;
        var res = new int[nums.Length];
        foreach (var num in nums)
        {
            if (num > 0)
            {
                res[posIdx] = num;
                posIdx += 2;
            }
            else
            {
                res[negIdx] = num;
                negIdx += 2;
            }
        }
        return res;
    }
}