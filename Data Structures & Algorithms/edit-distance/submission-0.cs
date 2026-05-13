public class Solution {
    public int MinDistance(string word1, string word2) {
        int l1 = word1.Length, l2 = word2.Length;
        int[,] dp = new int[l1 + 1, l2 + 1];

        // initialize boundary conditions
        for (int c = 0; c < l2; c++)
            dp[l1, c] = l2 - c;

        for(int r = 0; r < l1; r++)
            dp[r, l2] = l1 - r;

        // bottom-up dp
        for(int i = l1 - 1; i >= 0; i--)
        {
            for(int j = l2 - 1; j >= 0; j--)
            {
                if (word1[i] == word2[j]) dp[i, j] = dp[i + 1, j + 1];
                else
                {
                    int insert = dp[i, j + 1];
                    int delete = dp[i + 1, j];
                    int replace = dp[i + 1, j + 1];

                    dp[i, j] = 1 + Math.Min(insert, Math.Min(delete, replace));
                }
            }
        }

        return dp[0, 0];
    }
}
