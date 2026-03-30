public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0, l = 0, r = heights.Length - 1;
        while(l < r)
        {
            int lv = heights[l], rv = heights[r];
            if (lv < rv)
                res = Math.Max(res, lv * (r - l++));
            else
                res = Math.Max(res, rv * (r-- - l));
        }
        return res;
    }
}
