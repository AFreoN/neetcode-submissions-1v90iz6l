public class Solution {
    public int Trap(int[] height) {
        int total = height.Length;
        if (total <= 2) return 0;
        int result = 0;
        int l = 0, r = total - 1, lm = 0, rm = 0;
        while(l < r)
        {
            int lh = height[l], rh = height[r];
            if (lh < rh)
            {
                if (lh >= lm)
                    lm = lh;
                else
                    result += lm - lh;
                l++;
            }
            else
            {
                if (rh >= rm)
                    rm = rh;
                else
                    result += rm - rh;
                r--;
            }
        }
        return result;
    }
}
