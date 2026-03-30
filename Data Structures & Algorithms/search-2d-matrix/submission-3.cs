public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int cl = matrix[0].Length;
        int l = 0, r = (matrix.Length * matrix[0].Length) - 1, m, rem;

        while(l <= r)
        {
            m = l + (r - l) / 2;
            int t = matrix[Math.DivRem(m, cl, out rem)][rem];

            if (target > t)
                l = m + 1;
            else if (target < t)
                r = m - 1;
            else
                return true;
        }
        return false;
    }
}
