public class Solution {
    static readonly (int r, int c)[] dirs = new (int, int)[] { (0,1),(1,0),(0,-1),(-1,0) };
    public int IslandPerimeter(int[][] grid) {
        int rl = grid.Length, cl = grid[0].Length, res = 0;

        void accumulate(int row, int col)
        {
            res += 4;
            foreach(var d in dirs)
            {
                int r = row + d.r;
                int c = col + d.c;
                if (r < 0 || r >= rl || c < 0 || c >= cl) continue;
                if (grid[r][c] == 1) res--;
            }
        }
        for (int i = 0; i < rl; i++)
        {
            for (int j = 0; j < cl; j++)
            {
                if (grid[i][j] == 1)
                {
                    accumulate(i, j);
                }
            }
        }
        return res;
    }
}