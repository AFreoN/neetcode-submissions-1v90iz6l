public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        int m = s1.Length, n = s2.Length;
        if (m + n != s3.Length) return false;

        bool[,] dp = new bool[m + 1, n + 1];
        dp[m, n] = true;

        // bottom-up
        for (int i = m; i >= 0; i--)
        {
            for (int j = n; j >= 0; j--)
            {
                // if taking from s1 matches s3 and there is valid path from bottom
                if (i < m && s1[i] == s3[i + j] && dp[i + 1, j])
                    dp[i, j] = true;

                // if taking from s2 matches s3 and there is valid path from right
                if(j < n && s2[j] == s3[i + j] && dp[i, j + 1])
                    dp[i,j] = true;
            }
        }

        return dp[0, 0];
    }
}