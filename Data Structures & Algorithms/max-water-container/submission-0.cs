public class Solution {
    public int MaxArea(int[] heights) {
        int res = 0, l = 0, r = heights.Length - 1;
        while(l < r)
        {
            int lv = heights[l], rv = heights[r];
            res = Math.Max(res, Math.Min(lv, rv) * (r - l));
            if (lv < rv)
                l++;
            else
                r--;
        }
        return res;
    }
}
