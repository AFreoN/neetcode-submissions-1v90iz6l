public class Solution {
    public List<List<string>> Partition(string s) {
        List<List<string>> res = new List<List<string>>();
        int L = s.Length;
        bool[,] dp = new bool[L,L];
        for (int i = L - 1; i >= 0; i--)
            for (int j = i; j < L; j++)
                if(s[i] == s[j] && (j - i <= 2 || dp[i+1,j-1]))
                    dp[i,j] = true;

        DFS(s, 0, dp, new List<string>(), res);
        return res;
    }

    void DFS(string s, int start, bool[,] dp, List<string> pals, List<List<string>> res)
    {
        if(start >= s.Length)
        {
            res.Add(new List<string>(pals));
            return;
        }

        for(int end = start; end < s.Length; end++)
        {
            if(dp[start,end])
            {
                pals.Add(s.Substring(start, end - start + 1));
                DFS(s, end + 1, dp, pals, res);
                pals.RemoveAt(pals.Count - 1);
            }
        }
    }
}
