public class Solution {
    public bool Exist(char[][] board, string word) {
        int mr = board.Length, mc = board[0].Length;
        for(int i  = 0; i < mr; i++)
            for(int j = 0; j < mc; j++)
                if (board[i][j] == word[0] && DFS(board, word, i, j, 0))
                    return true;

        return false;
    }

    bool DFS(char[][] board, string word, int row, int col, int idx)
    {
        if(idx == word.Length) return true;
        if(row < 0 || col < 0 || 
            row >= board.Length || col >= board[0].Length || 
            board[row][col] != word[idx])
            return false;

        char tmp = board[row][col];
        board[row][col] = '#';

        bool found = DFS(board, word, row - 1, col, idx + 1) ||
                     DFS(board, word, row + 1, col, idx + 1) ||
                     DFS(board, word, row, col - 1, idx + 1) ||
                     DFS(board, word, row, col + 1, idx + 1);

        board[row][col] = tmp;
        return found;
    }
}
