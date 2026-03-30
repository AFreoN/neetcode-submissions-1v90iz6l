public class Solution {
    public void SetZeroes(int[][] matrix) {
        int rl = matrix.Length, cl = matrix[0].Length;
        bool rowZero = false;

        for (int r = 0; r < rl; r++)
        {
            for(int c = 0; c < cl; c++)
            {
                if(matrix[r][c] == 0)
                {
                    matrix[0][c] = 0;
                    if (r == 0) rowZero = true;
                    else matrix[r][0] = 0;
                }
            }
        }

        for (int r = 1; r < rl; r++)
            for (int c = 1; c < cl; c++)
                if (matrix[r][0] == 0 || matrix[0][c] == 0)
                    matrix[r][c] = 0;

        if (matrix[0][0] == 0)
            for (int r = 1; r < rl; r++)
                matrix[r][0] = 0;

        if (rowZero)
            for (int c = 0; c < cl; c++)
                matrix[0][c] = 0;
    }
}
