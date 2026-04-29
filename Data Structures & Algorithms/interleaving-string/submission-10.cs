public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        int m = s1.Length, n = s2.Length;

        if (m + n != s3.Length) return false;   // can't interleave if length is different
        // if (m > n) return IsInterleave(s2, s1, s3); //make sure n is the longest

        bool[] dp = new bool[Math.Max(m,n) + 1];

        for (int i = m; i >= 0; i--)
        {
            for (int j = n; j >= 0; j--)
            {
                if (i == m && j == n)   // assume that all characters from s3 has been used
                {
                    dp[j] = true;
                    continue;
                }

                // check if s1 matches s3 and there is valid path from bottom
                bool canUseS1 = i < m && s1[i] == s3[i + j] && dp[j]; // using j, because we're still having unupdated value which is bottom

                // check if s2 maches s3 and there is valid path from right
                bool canUseS2 = j < n && s2[j] == s3[i + j] && dp[j + 1];

                dp[j] = canUseS1 || canUseS2;
            }
        }

        return dp[0];
    }
}