public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        int n1 = s1.Length, n2 = s2.Length;
        if (n1 + n2 != s3.Length) return false;

        if (n1 > n2)
        {
            (s1, s2) = (s2, s1);
            (n1, n2) = (n2, n1);
        }
        
        Span<bool> dp = stackalloc bool[n2 + 1];
        dp[n2] = true;
        
        Span<bool> nextDp = stackalloc bool[n2 + 1];

        for(int i = n1; i >= 0; i--)
        {            
            for (int j = n2; j >= 0; j--)
            {
                bool current = false;
                if (i == n1 && j == n2) current = true;

                if (i < n1 && s1[i] == s3[i + j] && dp[j])
                    current = true;

                if (j < n2 && s2[j] == s3[i + j] && nextDp[j + 1])
                    current = true;

                nextDp[j] = current;
            }

            nextDp.CopyTo(dp);
        }

        return dp[0];
    }
}