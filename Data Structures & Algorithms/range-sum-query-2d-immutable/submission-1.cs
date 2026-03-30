public class NumMatrix {
    int[,] preMat;
    public NumMatrix(int[][] matrix) {
        int rl = matrix.Length;
        int cl = matrix[0].Length;
        preMat = new int[rl + 1, cl + 1];
        for(int i = 0; i < rl; i++)
        {
            int prefix = 0;
            for (int j = 0; j < cl; j++)
            {
                prefix += matrix[i][j];
                int above = preMat[i, j + 1];
                preMat[i + 1, j + 1] = prefix + above;
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        return preMat[row2 + 1, col2 + 1]
                - preMat[row1, col2 + 1]
                - preMat[row2 +1, col1]
                + preMat[row1, col1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */