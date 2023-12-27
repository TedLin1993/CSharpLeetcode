namespace CSharpLeetcode.leetcode;

public class _48
{
    public void Rotate(int[][] m)
    {
        var n = m.Length;
        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < n - 1 - i * 2; j++)
            {
                (m[i][i + j], m[i + j][n - 1 - i], m[n - 1 - i][n - 1 - i - j], m[n - 1 - i - j][i])
                    = (m[n - 1 - i - j][i], m[i][i + j], m[i + j][n - 1 - i], m[n - 1 - i][n - 1 - i - j]);
            }
        }
    }
}