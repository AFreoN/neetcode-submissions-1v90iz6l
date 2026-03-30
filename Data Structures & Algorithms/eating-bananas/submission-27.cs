public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1, r = piles.Max();
        while(l <= r)
        {
            int m = l + (r - l) / 2;
            if(m > r)
            {
                r = m - 1;
                continue;
            }
            long ch = 0;
            foreach (int x in piles)
                ch += (x + (long)m - 1) / m;

            if (ch <= h) r = m - 1;
            else l = m + 1;
        }
        return l;
    }
}
