public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        List<int> result = new List<int>();
        int top = 0, bottom = matrix.Length - 1, left = 0, right = matrix[0].Length - 1;

        while(top <= bottom && left <= right)
        {
            //traverse right
            for (int c = left; c <= right; c++)
                result.Add(matrix[top][c]);
            if(++top > bottom) break;

            //traverse down
            for (int r = top; r <= bottom; r++)
                result.Add(matrix[r][right]);
            if(left > --right) break;

            //traverse left
            for(int c = right; c >= left; c--)
                result.Add(matrix[bottom][c]);
            if(top > --bottom) break;

            //traverse up
            for (int r = bottom; r >= top; r--)
                result.Add(matrix[r][left]);

            left++;
        }

        return result;
    }
}
