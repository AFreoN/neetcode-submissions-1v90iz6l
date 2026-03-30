public class Solution {
    public int NumDecodings(string s) {
        int n = s.Length;
        Dictionary<int, int> dp = new Dictionary<int, int>();
        dp[n] = 1;

        int dfs(int i)
        {
            if (dp.ContainsKey(i)) return dp[i];
            if (s[i] == '0') return 0;

            int res = dfs(i + 1);
            if(i + 1 < n && (s[i] == '1' || s[i] == '2' && s[i + 1] <= '6'))
                res += dfs(i + 2);
            dp[i] = res;
            return res;
        }
        return dfs(0);
    }
}
