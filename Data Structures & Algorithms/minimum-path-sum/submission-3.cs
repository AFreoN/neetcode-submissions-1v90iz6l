public class Solution {
    public int MinPathSum(int[][] grid) {
        int rL = grid.Length, cL = grid[0].Length;
        int[] dp = new int[cL];
        dp[^1] = grid[^1][^1];

        for(int c = cL - 2; c >= 0; c--)
            dp[c] = grid[^1][c] + dp[c + 1]; 

        for(int r = rL - 2; r >= 0; r--)
        {
            dp[^1] = grid[r][^1] + dp[^1];
            for(int c = cL - 2; c >= 0; c--)
            {
                dp[c] = grid[r][c] + Math.Min(dp[c], dp[c+1]);
            }
        }

        return dp[0];
    }
}