public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int cl = matrix[0].Length - 1;
        int l = 0, r = matrix.Length - 1, rm = 0, cm = 0;
        while(l <= r)
        {
            rm = l + (r - l) / 2;
            if (target <= matrix[rm][cl])
                r = rm - 1;
            else
                l = rm + 1;
        }

        if (l >= matrix.Length) return false;
        rm = l;

        l = 0; r = cl;
        while(l <= r)
        {
            cm = l + (r - l) / 2;
            if (matrix[rm][cm] == target)
                return true;
            
            if(target < matrix[rm][cm])
                r = cm - 1;
            else
                l = cm + 1;
        }

        return false;
    }
}
