public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
        Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
        Dictionary<string, HashSet<char>> sqs = new Dictionary<string, HashSet<char>>();

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if(board[i][j] == '.') continue;

                string s = (i / 3) + "," + (j / 3);
                char v = board[i][j];
                if (rows.ContainsKey(i) && rows[i].Contains(v) ||
                    cols.ContainsKey(j) && cols[j].Contains(v) ||
                    sqs.ContainsKey(s) && sqs[s].Contains(v))
                    return false;

                    if(!rows.ContainsKey(i)) rows.Add(i, new HashSet<char> { v });
                    else rows[i].Add(v);
                    if (!cols.ContainsKey(j)) cols.Add(j, new HashSet<char> { v });
                    else cols[j].Add(v);
                    if (!sqs.ContainsKey(s)) sqs.Add(s, new HashSet<char> { v });
                    else sqs[s].Add(v);
            }
        }
        return true;
    }
}
