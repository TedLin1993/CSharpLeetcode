namespace CSharpLeetcode.leetcode
{
    public class Spiral_Matrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            var m = matrix.Length;
            var n = matrix[0].Length;
            var res = new List<int>();
            var dirs = new List<(int x, int y)> { (0, 1), (1, 0), (0, -1), (-1, 0) };
            var dirIdx = 0;
            var x = 0;
            var y = 0;
            while (res.Count < m * n - 1)
            {
                res.Add(matrix[x][y]);
                matrix[x][y] = 101;
                var nextX = x + dirs[dirIdx].x;
                var nextY = y + dirs[dirIdx].y;
                while (nextX < 0 || nextX >= m || nextY < 0 || nextY >= n || matrix[nextX][nextY] == 101)
                {
                    dirIdx++;
                    if (dirIdx == 4) dirIdx = 0;
                    nextX = x + dirs[dirIdx].x;
                    nextY = y + dirs[dirIdx].y;
                }
                x = nextX;
                y = nextY;
            }
            res.Add(matrix[x][y]);
            return res;
        }
    }
}