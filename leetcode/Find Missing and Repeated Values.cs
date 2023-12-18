namespace CSharpLeetcode.leetcode;

public class Find_Missing_and_Repeated_Values
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        var n = grid.Length;
        var visited = new bool[n * n + 1];
        var a = -1;
        foreach (var row in grid)
        {
            foreach (var val in row)
            {
                if (visited[val])
                {
                    a = val;
                }
                else
                {
                    visited[val] = true;
                }
            }
        }
        var b = -1;
        for (int i = 1; i <= n * n; i++)
        {
            if (!visited[i])
            {
                b = i;
                break;
            }
        }
        return [a, b];
    }
}