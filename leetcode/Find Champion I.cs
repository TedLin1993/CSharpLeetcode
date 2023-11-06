namespace CSharpLeetcode.leetcode;

public class Find_Champion_I
{
    public int FindChampion(int[][] grid)
    {
        var n = grid.Length;
        var res = -1;
        var max = 0;
        for (int i = 0; i < n; i++)
        {
            var temp = grid[i].Sum();
            if (temp > max)
            {
                max = temp;
                res = i;
            }
        }
        return res;
    }
}