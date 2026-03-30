public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        DFS(0,0,n,result,"");
        return result;
    }

    void DFS(int open, int close, int n, List<string> res, string current)
    {
        if(open == close && open == n)
        {
            res.Add(current);
            return;
        }
        if(open < n) DFS(open + 1, close, n, res, current + "(");
        if(close < open) DFS(open, close + 1, n, res, current + ")");
    }
}
