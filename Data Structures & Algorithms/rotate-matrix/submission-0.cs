public class Solution {
    public void Rotate(int[][] matrix) {
        Array.Reverse(matrix);
        int rl = matrix.Length, cl = matrix[0].Length;
        for (int i = 0; i < rl; i++)
        {
            for (int j = i; j < cl; j++)
            {
                (matrix[i][j], matrix[j][i]) = (matrix[j][i], matrix[i][j]);
            }
        }
    }
}
