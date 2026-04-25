public class Solution {
    public bool IsValidSudoku(char[][] board) {
        Dictionary<int, HashSet<char>> row = new();
        Dictionary<int, HashSet<char>> col = new();
        Dictionary<int, HashSet<char>> box = new();

        for(int r = 0; r < 9; r++)
        {
            for(int c = 0; c < 9; c++)
            {
                if (board[r][c] == '.') continue;

                char v = board[r][c];
                int boxId = (r / 3) * 3 + c / 3;

                if (!row.ContainsKey(r)) row.Add(r, new HashSet<char>());
                if (!col.ContainsKey(c)) col.Add(c, new HashSet<char>());
                if (!box.ContainsKey(boxId)) box.Add(boxId, new HashSet<char>());

                if (row[r].Contains(v) || col[c].Contains(v) || box[boxId].Contains(v)) return false;

                row[r].Add(v);
                col[c].Add(v);
                box[boxId].Add(v);
            }
        }

        return true;
    }
}
