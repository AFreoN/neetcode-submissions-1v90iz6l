public class Solution {
    public bool WordBreak(string s, List<string> wordDict) {
        int n = s.Length;
        ReadOnlySpan<char> span = s.AsSpan();
        Span<bool> visited = stackalloc bool[n + 1];
        visited[n] = true;

        for (int i = n - 1; i >= 0; i--)
        {
            foreach(string word in wordDict)
            {
                int wl = word.Length;
                if (i + wl <= n && word == s.Substring(i, wl) && visited[i + wl])
                {
                    visited[i] = true;
                    break;
                }
            }
        }

        return visited[0];
    }
}
