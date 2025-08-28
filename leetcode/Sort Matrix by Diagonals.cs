public class _3446
{
    public int[][] SortMatrix(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        //bottom-left
        for (int i = 0; i < m; i++)
        {
            var list = new List<int>();
            var j = 0;
            while (i + j < m && j < n)
            {
                list.Add(grid[i + j][j]);
                j++;
            }
            list.Sort((a, b) => b - a);

            j = 0;
            while (i + j < m && j < n)
            {
                grid[i + j][j] = list[j];
                j++;
            }
        }

        //top-right
        for (int i = 1; i < n; i++)
        {
            var list = new List<int>();
            var j = 0;
            while (i + j < n && j < m)
            {
                list.Add(grid[j][i + j]);
                j++;
            }
            list.Sort();

            j = 0;
            while (i + j < n && j < m)
            {
                grid[j][i + j] = list[j];
                j++;
            }
        }

        return grid;
    }
}