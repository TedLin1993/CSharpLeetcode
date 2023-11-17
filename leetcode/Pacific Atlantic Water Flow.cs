namespace CSharpLeetcode.leetcode;
public class Pacific_Atlantic_Water_Flow
{
    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        var m = heights.Length;
        var n = heights[0].Length;
        var dirs = new List<(int x, int y)> { (1, 0), (-1, 0), (0, 1), (0, -1) };
        void dfs(int i, int j, bool[,] ocean)
        {
            if (ocean[i, j]) return;
            ocean[i, j] = true;
            foreach (var dir in dirs)
            {
                var x = i + dir.x;
                var y = j + dir.y;
                if (x >= 0 && x < m && y >= 0 && y < n && heights[i][j] <= heights[x][y])
                    dfs(x, y, ocean);
            }
        }
        var isPac = new bool[m, n];
        var isAtl = new bool[m, n];
        for (int i = 0; i < n; i++)
        {
            dfs(0, i, isPac);
            dfs(m - 1, i, isAtl);

        }
        for (int i = 0; i < m; i++)
        {
            dfs(i, 0, isPac);
            dfs(i, n - 1, isAtl);
        }

        var res = new List<IList<int>>();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (isPac[i, j] && isAtl[i, j])
                {
                    res.Add(new List<int> { i, j });
                }
            }
        }
        return res;
    }

}

