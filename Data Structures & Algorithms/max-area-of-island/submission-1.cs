public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0, rl = grid.Length, cl = grid[0].Length;
        int DFS(int row, int col)
        {
            if(row < 0 || col < 0 || row >= rl || col >= cl || grid[row][col] == 0)
                return 0;

            grid[row][col] = 0;
            return 1 + DFS(row - 1, col)
                        + DFS(row + 1, col)
                        + DFS(row, col - 1)
                        + DFS(row, col + 1);
        }

        for (int i = 0; i < rl; i++)
            for(int j = 0; j < cl; j++)
                if(grid[i][j] == 1)
                    max = Math.Max(max, DFS(i, j));
        return max;
    }
}
