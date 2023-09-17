using CSharpLeetcode.model;

namespace CSharpLeetcode.leetcode
{
    public partial class Solution
    {
        public int MinimumEffortPath(int[][] heights)
        {
            var m = heights.Length;
            var n = heights[0].Length;
            var visited = new bool[m, n];
            var minHeap = new PriorityQueue<(int row, int col), int>();
            if (n > 1)
            {
                minHeap.Enqueue((0, 1), Math.Abs(heights[0][1] - heights[0][0]));
            }
            if (m > 1)
            {
                minHeap.Enqueue((1, 0), Math.Abs(heights[1][0] - heights[0][0]));
            }
            visited[0, 0] = true;
            var res = 0;
            var dirs = new int[][] {
                new int[] {0, 1},
                new int[] {0, -1},
                new int[] {1, 0},
                new int[] {-1, 0},
            };
            while (minHeap.Count > 0)
            {
                minHeap.TryDequeue(out var cell, out var effort);
                res = Math.Max(res, effort);
                var (row, col) = cell;
                if (row == m - 1 && col == n - 1)
                {
                    return res;
                }
                visited[row, col] = true;
                foreach (var dir in dirs)
                {
                    var nextRow = row + dir[0];
                    var nextCol = col + dir[1];
                    if (nextRow >= 0 && nextRow < m && nextCol >= 0 && nextCol < n && !visited[nextRow, nextCol])
                    {
                        var nextEffor = Math.Abs(heights[nextRow][nextCol] - heights[row][col]);
                        minHeap.Enqueue((nextRow, nextCol), nextEffor);
                    }
                }
            }
            return res;
        }
        public void TestMinimumEffortPath()
        {
            Console.WriteLine(MinimumEffortPath(new int[][] {
                new int[] {1, 2, 2},
                new int[] {3, 8, 2},
                new int[] {5, 3, 5}})
            ); //2
            Console.WriteLine(MinimumEffortPath(new int[][] {
                new int[] {3},})
            ); //0
        }
    }
}