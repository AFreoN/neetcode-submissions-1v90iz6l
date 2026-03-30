public class Solution {
    static readonly (int r,int c)[] dirs = new (int,int)[] { (1,0), (0,1) };
    
    public int ShortestPath(int[][] grid) {
        if (grid[0][0] == 1 || grid[^1][^1] == 1) return -1;

        int rl = grid.Length, cl = grid[0].Length;
        int count = 0;

        Queue<(int row, int col)> q = new Queue<(int,int)>();
        q.Enqueue((0,0));

        while (q.Count > 0)
        {
            for (int i = q.Count; i > 0; i--)
            {
                var cur = q.Dequeue();

                if (cur.row == rl - 1 && cur.col == cl - 1) return count;

                foreach (var d in dirs)
                {
                    int r = cur.row + d.r;
                    int c = cur.col + d.c;
                    if (r >= 0 && c >= 0 && r < rl && c < cl && grid[r][c] != 1)
                        q.Enqueue((r, c));
                }
            }
            count++;
        }

        return -1;
    }
}
