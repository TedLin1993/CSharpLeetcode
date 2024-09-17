namespace CSharpLeetcode.leetcode;

public class _539
{
    public int FindMinDifference(IList<string> timePoints)
    {
        var n = 60 * 24;
        var times = new bool[n];
        var min = int.MaxValue;
        for (int i = 0; i < timePoints.Count; i++)
        {
            var t = GetMinutes(timePoints[i]);
            if (times[t]) return 0;
            times[t] = true;
            min = Math.Min(min, t);
        }

        var res = int.MaxValue;
        var prev = min;
        for (int i = prev + 1; i < n; i++)
        {
            if (!times[i]) continue;
            res = Math.Min(res, i - prev);
            prev = i;
        }
        res = Math.Min(res, min - prev + n);
        return res;
    }

    int GetMinutes(string timePoint)
    {
        return 600 * (timePoint[0] - '0') + 60 * (timePoint[1] - '0')
            + 10 * (timePoint[3] - '0') + (timePoint[4] - '0');
    }
}