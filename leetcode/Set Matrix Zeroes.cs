namespace CSharpLeetcode.leetcode;

public class _73
{
    //O(m+n)
    public void SetZeroes(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var isZeroRow = new bool[m];
        var isZeroCol = new bool[n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    isZeroRow[i] = true;
                    isZeroCol[j] = true;
                }
            }
        }
        for (int i = 0; i < m; i++)
        {
            if (!isZeroRow[i]) continue;
            for (int j = 0; j < n; j++)
            {
                matrix[i][j] = 0;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (!isZeroCol[i]) continue;
            for (int j = 0; j < m; j++)
            {
                matrix[j][i] = 0;
            }
        }
    }
    //O(1)
    public void SetZeroes_2(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var isZeroFisrtRow = false;
        var isZeroFirstCol = false;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    if (i == 0) isZeroFisrtRow = true;
                    if (j == 0) isZeroFirstCol = true;
                    matrix[0][j] = 0;
                    matrix[i][0] = 0;
                }
            }
        }
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0) matrix[i][j] = 0;
            }
        }
        if (isZeroFisrtRow)
        {
            for (int i = 0; i < n; i++)
            {
                matrix[0][i] = 0;
            }
        }
        if (isZeroFirstCol)
        {
            for (int i = 0; i < m; i++)
            {
                matrix[i][0] = 0;
            }
        }
    }
}