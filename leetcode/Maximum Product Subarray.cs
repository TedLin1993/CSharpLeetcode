namespace CSharpLeetcode.leetcode;
public class Maximum_Product_Subarray
{
    public int MaxProduct(int[] nums)
    {
        var n = nums.Length;
        var l = 0;
        var r = 0;
        var res = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            l = (l == 0 ? 1 : l) * nums[i];
            r = (r == 0 ? 1 : r) * nums[n - 1 - i];
            res = Math.Max(res, Math.Max(l, r));
        }
        return res;
    }
}