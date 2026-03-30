public class Solution {
    public int ShipWithinDays(int[] weights, int days) {
        int n = weights.Length, l = weights.Max(), r = l * (int)Math.Ceiling((double)n / days);

        bool CanShip(int cap)
        {
            int ships = 0, currCap = 0;

            foreach(int w in weights)
            {
                currCap += w;
                if(currCap > cap)
                {
                    if (++ships > days) return false;
                    currCap = w;
                }
            }
            ships++;
            return ships <= days;
        }

        while(l <= r)
        {
            int m = (r + l) / 2;

            if (CanShip(m)) //we did it earlier, so reduce weight to increase number of days
                r = m - 1;
            else l = m + 1;
        }
        return l;
    }
}