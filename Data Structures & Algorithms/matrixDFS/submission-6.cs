public class Solution {
    public int CountPaths(int[][] grid)
    {
        int count = 0, rL = grid.Length, cL = grid[0].Length;

        void backtrack(int r, int c, bool[,] visited)
        {
            if (r < 0 || c < 0 || r >= rL || c >= cL || visited[r, c] || grid[r][c] == 1) return;

            if (r == rL - 1 && c == cL - 1)
            {
                count++;
                return;
            }

            visited[r,c] = true;
            backtrack(r + 1, c, visited);
            backtrack(r - 1, c, visited);
            backtrack(r, c + 1, visited);
            backtrack(r, c - 1, visited);
            visited[r, c] = false;
        }

        backtrack(0, 0, new bool[rL, cL]);
        return count;
    }
}