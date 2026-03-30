public class Solution {
    public int NumIslands(char[][] grid) {
        int rm = grid.Length, cm = grid[0].Length, result = 0;

        void DFS(int row, int col)
        {
            if (row < 0 || col < 0 || row >= rm || col >= cm || grid[row][col] == '0')
                return;

            grid[row][col] = '0';
            DFS(row - 1, col);
            DFS(row + 1, col);
            DFS(row, col - 1);
            DFS(row, col + 1);
        }

        for (int i = 0; i < rm; i++)
            for (int j = 0; j < cm; j++)
            {
                if(grid[i][j] == '1')
                {
                    result++;
                    DFS(i, j);
                }
            }

        return result;
    }
}
