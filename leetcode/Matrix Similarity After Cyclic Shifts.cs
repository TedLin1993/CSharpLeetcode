namespace CSharpLeetcode.leetcode;
public class Matrix_Similarity_After_Cyclic_Shifts
{
    public bool AreSimilar(int[][] mat, int k)
    {
        var m = mat.Length;
        var n = mat[0].Length;
        k %= n;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                var idx = j + k;
                if (idx >= n) idx -= n;
                if (mat[i][j] != mat[i][idx]) return false;
            }
        }
        return true;
    }
}