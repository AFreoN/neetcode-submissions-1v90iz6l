public class Solution {
    public int MinPathSum(int[][] grid) {
        int rL = grid.Length, cL = grid[0].Length;
        int[] dp = new int[cL];

        for(int r = rL - 1; r >= 0; r--)
        {
            for(int c = cL - 1; c >= 0; c--)
            {
                if(r == rL - 1)
                {
                    int right = c == cL - 1 ? 0 : dp[c+1];
                    dp[c] = grid[r][c] + right;
                }
                else
                {
                    int right = c == cL - 1 ? dp[c] : dp[c+1];
                    dp[c] = grid[r][c] + Math.Min(dp[c], right);
                }
            }
        }

        return dp[0];
    }
}