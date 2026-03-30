public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        if(piles.Length == h) return piles.Max();
        int l = 1, r = piles.Max(), k = piles.Max();
        while(l <= r)
        {
            int m = l + (r - l) / 2;
            long ch = 0;
            foreach (int x in piles)
                ch += (long)(x + m - 1) / m;
            
            if (ch <= h)
            {
                k = m; r = m - 1;
            }
            else
                l = m + 1;
        }
        return k;
    }
}
