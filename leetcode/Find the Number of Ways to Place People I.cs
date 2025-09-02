namespace CSharpLeetcode.leetcode;

public class _3025
{
    public int NumberOfPairs(int[][] points)
    {
        Array.Sort(points, (a, b) =>
        {
            if (a[0] != b[0]) return a[0] - b[0];
            return b[1] - a[1];
        });

        var n = points.Length;
        var res = 0;
        for (int i = 1; i < n; i++)
        {
            var min = 100;
            for (int j = i - 1; j >= 0; j--)
            {
                if (points[j][1] < points[i][1] || points[j][1] >= min) continue;
                res++;
                min = points[j][1];
            }
        }

        return res;
    }
}