public class Solution {
    const int CELL = int.MaxValue;
    public void islandsAndTreasure(int[][] grid) {
        Queue<(int row, int col)> queue = new Queue<(int row, int col)>();
        int rl = grid.Length, cl = grid[0].Length, land = 0, distance = 0;
        for (int i = 0; i < rl; i++)
            for (int j = 0; j < cl; j++)
                if (grid[i][j] == 0) queue.Enqueue((i, j));
                else if (grid[i][j] == CELL) land++;

        if (land == 0) return;
        (int r, int c)[] dirs = { (-1, 0), (1, 0), (0, -1), (0, 1) };
        while(queue.Count > 0)
        {
            int qLength = queue.Count;
            distance++;
            for(int i = 0; i < qLength; i++)
            {
                var curr = queue.Dequeue();
                int row = curr.row, col = curr.col;
                foreach (var v in dirs)
                {
                    int r = row + v.r;
                    int c = col + v.c;
                    if (r < 0 || c < 0 || r >= rl || c >= cl || grid[r][c] != CELL) continue;
                    queue.Enqueue((r, c));
                    grid[r][c] = distance;
                }
            }
        }
    }
}
