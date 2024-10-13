namespace CSharpLeetcode.leetcode;

public class _2406
{
    public int MinGroups(int[][] intervals)
    {
        var max = 0;
        foreach (var inter in intervals)
        {
            max = Math.Max(max, inter[1]);
        }

        var arr = new int[max + 2];
        foreach (var inter in intervals)
        {
            arr[inter[0]]++;
            arr[inter[1] + 1]--;
        }

        var res = 0;
        var cur = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            cur += arr[i];
            res = Math.Max(res, cur);
        }
        return res;
    }
}