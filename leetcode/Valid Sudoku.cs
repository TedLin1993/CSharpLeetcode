namespace CSharpLeetcode.leetcode;
public class Valid_Sudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        var n = 9;
        //row
        for (int i = 0; i < n; i++)
        {
            var set = new HashSet<char>();
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] == '.') continue;
                if (set.Contains(board[i][j])) return false;
                set.Add(board[i][j]);
            }
        }

        //column
        for (int i = 0; i < n; i++)
        {
            var set = new HashSet<char>();
            for (int j = 0; j < n; j++)
            {
                if (board[j][i] == '.') continue;
                if (set.Contains(board[j][i])) return false;
                set.Add(board[j][i]);
            }
        }

        //box
        for (int i = 0; i < n; i += 3)
        {
            for (int j = 0; j < n; j += 3)
            {
                var set = new HashSet<char>();
                for (int k = i; k < i + 3; k++)
                {
                    for (int l = j; l < j + 3; l++)
                    {
                        if (board[k][l] == '.') continue;
                        if (set.Contains(board[k][l])) return false;
                        set.Add(board[k][l]);
                    }
                }
            }
        }
        return true;
    }
}