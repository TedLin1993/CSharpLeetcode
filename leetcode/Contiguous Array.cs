namespace CSharpLeetcode.leetcode;
public class Contiguous_Array
{
    public int FindMaxLength(int[] nums)
    {
        var n = nums.Length;
        var dict = new Dictionary<int, int>();
        dict[0] = -1;
        var cur = 0;
        var res = 0;
        for (int i = 0; i < n; i++)
        {
            cur += nums[i] == 0 ? -1 : 1;
            if (dict.ContainsKey(cur))
            {
                res = Math.Max(res, i - dict[cur]);
            }
            else
            {
                dict[cur] = i;
            }
        }
        return res;
    }
}