public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        int rl = obstacleGrid.Length, cl = obstacleGrid[0].Length;
        int[] dp = new int[cl + 1];
        dp[cl - 1] = 1;

        for (int r = rl - 1; r >= 0; r--)
        {
            for (int c = cl - 1; c >= 0; c--)
            {
                if (obstacleGrid[r][c] != 1)
                    dp[c] += dp[c + 1];
                else
                    dp[c] = 0;
            }
        }

        return dp[0];
    }
}