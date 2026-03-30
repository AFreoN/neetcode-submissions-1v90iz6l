public class Solution {
    public int MinPathSum(int[][] grid) {
        // dp last row
        for (int c = grid[0].Length - 2; c >= 0; c--)
            grid[^1][c] = grid[^1][c] + grid[^1][c + 1];

        // dp last column
        for(int r = grid.Length - 2; r >= 0; r--)
            grid[r][^1] = grid[r][^1] + grid[r + 1][^1];

        for (int r = grid.Length - 2; r >= 0; r--)
        {
            for(int c = grid[0].Length - 2; c >= 0; c--)
            {
                grid[r][c] += Math.Min(grid[r + 1][c], grid[r][c + 1]);
            }
        }

        return grid[0][0];
    }
}