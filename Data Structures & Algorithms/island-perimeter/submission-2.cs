public class Solution {
    public int IslandPerimeter(int[][] grid) {
            int rl = grid.Length, cl = grid[0].Length;

            bool[,] visited = new bool[rl, cl];

            int dfs(int row, int col)
            {
                if (row < 0 || col < 0 || row >= rl || col >= cl || grid[row][col] == 0) return 1;
                if(visited[row,col]) return 0;

                visited[row, col] = true;
                return dfs(row, col + 1) + dfs(row + 1, col) + dfs(row - 1, col) + dfs(row, col - 1);
            }
            for (int i = 0; i < rl; i++)
                for (int j = 0; j < cl; j++)
                    if (grid[i][j] == 1)
                        return dfs(i, j);

            return 0;
    }
}