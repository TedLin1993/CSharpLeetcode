namespace CSharpLeetcode.leetcode;

public class _1277
{
    public int CountSquares(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;
        var res = 0;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                var k = 0;
                while (i + k < m && j + k < n)
                {
                    var isSquare = true;
                    for (int l = 0; l <= k; l++)
                    {
                        if (matrix[i + k][j + l] != 1 || matrix[i + l][j + k] != 1)
                        {
                            isSquare = false;
                            break;
                        }
                    }
                    if (!isSquare) break;

                    res++;
                    k++;
                }
            }
        }
        return res;
    }
}