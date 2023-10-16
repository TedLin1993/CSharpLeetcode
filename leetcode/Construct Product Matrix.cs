namespace CSharpLeetcode.leetcode
{
    public class Construct_Product_Matrix
    {
        public int[][] ConstructProductMatrix(int[][] grid)
        {
            var mod = 12345;
            var n = grid.Length;
            var m = grid[0].Length;

            var pre = new long[n * m + 1];
            pre[0] = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    var idx = i * m + j;
                    pre[idx + 1] = pre[idx] * grid[i][j] % mod;
                }
            }

            var suf = new long[n * m + 1];
            suf[n * m] = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = m - 1; j >= 0; j--)
                {
                    var idx = i * m + j;
                    suf[idx] = suf[idx + 1] * grid[i][j] % mod;
                }
            }

            var res = new int[n][];
            for (int i = 0; i < n; i++)
            {
                res[i] = new int[m];
                for (int j = 0; j < m; j++)
                {
                    var idx = i * m + j;
                    res[i][j] = (int)(pre[idx] * suf[idx + 1] % mod);
                }
            }
            return res;
        }
    }
}