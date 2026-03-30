public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rl = matrix.Length, cl = matrix[0].Length;

        void SetZero(int row, int col)
        {
            for (int r = 0; r < rl; r++)
                matrix[r][col] = 0;

            for (int c = 0; c < cl; c++)
                matrix[row][c] = 0;
        }

        HashSet<(int row, int col)> hash = new HashSet<(int row, int col)> ();
        for(int i = 0; i < rl; i++)
            for(int j = 0; j < cl; j++)
                if(matrix[i][j] == 0)
                    hash.Add((i, j));

        foreach(var h in hash)
            SetZero(h.row, h.col);
    }
}
