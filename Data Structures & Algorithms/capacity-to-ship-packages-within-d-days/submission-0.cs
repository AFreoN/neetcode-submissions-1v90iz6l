public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int n = weights.Length, l = weights.Max(), r = l * (n + days) / days;

        while(l <= r)
        {
            int m = (r + l) / 2;

            int d = 0, curr = 0;

            foreach(int w in weights)
            {
                curr += w;
                if(curr > m)
                {
                    d++;
                    curr = w;
                }
            }
            if (curr > 0) d++;

            // if (d == days) return m;
            if (d <= days) //we did it earlier, so reduce weight to increase number of days
                r = m - 1;
            else l = m + 1;
        }
        return l;
    }
}