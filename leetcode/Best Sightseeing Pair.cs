namespace CSharpLeetcode.leetcode;

public class _1014
{
    public int MaxScoreSightseeingPair(int[] values)
    {
        var res = 0;
        var mx = 0;
        for (int i = 0; i < values.Length; i++)
        {
            res = Math.Max(res, mx + values[i] - i);
            mx = Math.Max(mx, values[i] + i);
        }
        return res;
    }
}