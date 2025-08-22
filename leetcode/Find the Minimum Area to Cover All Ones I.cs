namespace CSharpLeetcode.leetcode;

public class _3195
{
    public int MinimumArea(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var left = n;
        var right = -1;
        var top = -1;
        var bot = m;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] == 0) continue;
                if (j < left) left = j;
                if (j > right) right = j;
                if (i < bot) bot = i;
                if (i > top) top = i;
            }
        }
        return (right - left + 1) * (top - bot + 1);
    }
}