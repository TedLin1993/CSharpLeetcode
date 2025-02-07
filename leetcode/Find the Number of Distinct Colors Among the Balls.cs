namespace CSharpLeetcode.leetcode;

public class _3160
{
    public int[] QueryResults(int limit, int[][] queries)
    {
        var n = queries.Length;
        var ballColor = new Dictionary<int, int>();
        var colorCount = new Dictionary<int, int>();
        var cur = 0;
        var res = new int[n];
        for (int i = 0; i < n; i++)
        {
            var ball = queries[i][0];
            var color = queries[i][1];
            if (ballColor.ContainsKey(ball))
            {
                colorCount[ballColor[ball]]--;
                if (colorCount[ballColor[ball]] == 0)
                {
                    cur--;
                }
            }
            ballColor[ball] = color;
            colorCount[color] = colorCount.GetValueOrDefault(color) + 1;
            if (colorCount[color] == 1) cur++;
            res[i] = cur;
        }
        return res;
    }
}