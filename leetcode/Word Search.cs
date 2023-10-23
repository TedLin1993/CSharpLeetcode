namespace CSharpLeetcode.leetcode
{
    public class Word_Search
    {
        public bool Exist(char[][] board, string word)
        {
            var m = board.Length;
            var n = board[0].Length;
            var dirs = new List<(int x, int y)> { (0, 1), (0, -1), (1, 0), (-1, 0) };
            bool dfs(int x, int y, int idx)
            {
                if (word[idx] != board[x][y]) return false;
                if (idx == word.Length - 1) return true;
                board[x][y] = '$';
                foreach (var dir in dirs)
                {
                    var nextX = x + dir.x;
                    var nextY = y + dir.y;
                    if (nextX >= 0 && nextX < m && nextY >= 0 && nextY < n && dfs(nextX, nextY, idx + 1))
                    {
                        return true;
                    }
                }
                board[x][y] = word[idx];
                return false;
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (dfs(i, j, 0)) return true;
                }
            }
            return false;
        }
    }
}