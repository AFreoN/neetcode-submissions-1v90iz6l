public class Solution {
    readonly (int row, int col)[] dirs = { (-1, 0), (1, 0), (0, -1), (0, 1) };
    public List<List<int>> PacificAtlantic(int[][] heights) {
        int mr = heights.Length, mc = heights[0].Length;
        bool[,] pac = new bool[mr, mc];
        bool[,] atl = new bool[mr, mc];
        
        void dfs(int r, int c, bool[,] visited)
        {
            visited[r, c] = true;

            foreach(var d in dirs)
            {
                int nr = r + d.row, nc = c + d.col;
                if (nr < 0 || nc < 0 || nr >= mr || nc >= mc || visited[nr, nc]) continue;
                if (heights[nr][nc] >= heights[r][c])
                    dfs(nr, nc, visited);
            }
        }

        for(int i = 0; i < mc; i++)
        {
            dfs(0, i, pac);
            dfs(mr - 1, i, atl);
        }
        for(int i = 0; i < mr; i++)
        {
            dfs(i, 0, pac);
            dfs(i, mc - 1, atl);
        }

        List<List<int>> res = new List<List<int>>();
        for(int i = 0; i < mr; i++)
            for(int j =0; j < mc; j++)
                if (pac[i,j] && atl[i,j])
                    res.Add(new List<int> { i, j });

        return res;
    }
}
