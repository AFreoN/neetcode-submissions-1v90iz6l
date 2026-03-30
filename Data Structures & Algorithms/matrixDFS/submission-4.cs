public class Solution {
    public int CountPaths(int[][] grid)
    {
        int count = 0;
        dfs(0, 0, grid, new bool[grid.Length, grid[0].Length], ref count);
        return count;
    }

    void dfs(int r, int c, int[][] grid, bool[,] visited, ref int count)
    {
        if(r < 0 || c < 0 || r >= grid.Length || c >= grid[0].Length || visited[r,c] || grid[r][c] == 1) return;

        if (r == grid.Length - 1 && c == grid[0].Length - 1)
        {
            count++;
            return;
        }

        visited[r,c] = true;
        dfs(r - 1, c, grid, visited, ref count);
        dfs(r + 1, c, grid, visited, ref count);
        dfs(r, c + 1, grid, visited, ref count);
        dfs(r, c - 1, grid, visited, ref count);
        visited[r,c] = false;
    }
}