public class Solution {
    public int OrangesRotting(int[][] grid) {
        int res = -1, rl = grid.Length, cl = grid[0].Length, fruit = 0;
        Queue<(int row, int col)> q = new Queue<(int row, int col)>();
        for (int i = 0; i < rl; i++)
            for (int j = 0; j < cl; j++)
                if (grid[i][j] == 2) q.Enqueue((i, j));
                else if (grid[i][j] == 1) fruit++;
        if (fruit == 0) return 0;
        (int row, int col)[] dir = { (-1, 0), (1, 0), (0, -1), (0, 1) };
        while(q.Count > 0)
        {
            int qCount = q.Count;
            res++;
            for(int i = 0; i < qCount; i++)
            {
                var v = q.Dequeue();
                foreach(var d in dir)
                {
                    int r = v.row + d.row, c = v.col + d.col;
                    if (r < 0 || c < 0 || r >= rl || c >= cl || grid[r][c] != 1) continue;
                    grid[r][c] = 2;
                    q.Enqueue((r, c));
                    fruit--;
                }
            }
        }
        return fruit == 0 ? res : -1;
    }
}
