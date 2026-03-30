public class Solution {
    public int MySqrt(int x) {
        int l = 0, r = 46340;
        while(l <= r)
        {
            int m = l + (r - l) / 2;
            int v = m * m;
            if(v <= x) l = m + 1;
            else r = m - 1;
        }
        return r;
    }
}