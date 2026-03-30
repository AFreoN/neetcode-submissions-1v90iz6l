public class Solution {
    public void Solve(char[][] board) {
        int ROWS = board.Length, COLS = board[0].Length;
        void dfs(int r, int c)
        {
            if (r < 0 || c < 0 || r >= ROWS || c >= COLS || board[r][c] != 'O') return;
            board[r][c] = 'Y';
            dfs(r + 1, c);
            dfs(r - 1, c);
            dfs(r, c + 1);
            dfs(r, c - 1);
        }
        for (int c = 0; c < COLS; c++)
        {
            if (board[0][c] == 'O') dfs(0, c);
            if (board[ROWS - 1][c] == 'O') dfs(ROWS - 1, c);
        }
        for (int r = 0; r < ROWS; r++)
        {
            if (board[r][0] == 'O') dfs(r, 0);
            if (board[r][COLS - 1] == 'O') dfs(r, COLS - 1);
        }
        for(int r = 0;  r < ROWS; r++)
        {
            for(int c = 0; c < COLS; c++)
            {
                if (board[r][c] == 'Y') board[r][c] = 'O';
                else if (board[r][c] == 'O') board[r][c] = 'X';
            }
        }
    }
}
