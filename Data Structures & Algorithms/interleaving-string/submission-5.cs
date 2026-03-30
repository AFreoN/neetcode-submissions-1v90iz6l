public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        if (s1.Length > s2.Length) return IsInterleave(s2, s1, s3);

        int m = s1.Length, n = s2.Length;
        if (m + n != s3.Length) return false;
        
        Span<bool> dp = stackalloc bool[n + 1];
        dp[n] = true;

        for(int i = m; i >= 0; i--)
        {
            for (int j = n; j >= 0; j--)
            {
                if (i == m && j == n)
                {
                    dp[j] = true;
                    continue;
                }

                bool current = false;

                if (i < m && s1[i] == s3[i + j] && dp[j])
                    current = true;
                
                if (j < n && s2[j] == s3[i + j] && dp[j + 1])
                    current = true;

                dp[j] = current;
            }
        }

        return dp[0];
    }
}