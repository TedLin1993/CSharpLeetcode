namespace CSharpLeetcode.leetcode;

public class _498
{
    public int[] FindDiagonalOrder(int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        var res = new int[m * n];
        var i = 0;
        var j = 0;
        var idx = 0;
        while (i < m && j < n)
        {
            res[idx] = mat[i][j];
            while (j + 1 < n && i > 0)
            {
                j++;
                i--;
                idx++;
                res[idx] = mat[i][j];
            }

            if (j < n - 1) j++;
            else if (i < m - 1) i++;
            else break;

            idx++;
            res[idx] = mat[i][j];
            while (i + 1 < m && j > 0)
            {
                i++;
                j--;
                idx++;
                res[idx] = mat[i][j];
            }

            if (i < m - 1) i++;
            else j++;
            idx++;
        }
        return res;
    }

    public void Test()
    {
        Console.WriteLine(FindDiagonalOrder([[1, 2, 3], [4, 5, 6], [7, 8, 9]]));
    }
}