public class Solution {
    public bool IsValidSudoku(char[][] board) {
            Dictionary<int, HashSet<char>> rows = new Dictionary<int, HashSet<char>>();
            Dictionary<int, HashSet<char>> cols = new Dictionary<int, HashSet<char>>();
            Dictionary<int, HashSet<char>> sqs = new Dictionary<int, HashSet<char>>();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(board[i][j] == '.') continue;

                    char v = board[i][j];
                    if (rows.ContainsKey(i) && rows[i].Contains(v) || cols.ContainsKey(j) && cols[j].Contains(v)) return false;
                    int s = ((i / 3) * 10) + (j / 3);
                    if (sqs.ContainsKey(s) && sqs[s].Contains(v)) return false;

                    if(!rows.ContainsKey(i)) rows.Add(i, new HashSet<char> { v });
                    if (!cols.ContainsKey(j)) cols.Add(j, new HashSet<char> { v });
                    if (!sqs.ContainsKey(s)) sqs.Add(s, new HashSet<char> { v });

                    rows[i].Add(v);
                    cols[j].Add(v);
                    sqs[s].Add(v);
                }
            }
            return true;
    }
}
