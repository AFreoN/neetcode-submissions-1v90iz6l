public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length, h = 0;
        int[] res = new int[n];
        
        for(int i = n - 1; i >= 0; i--)
        {
            int ct = temperatures[i];
            if (ct >= h)
                h = ct;
            else
            {
                int d = 1;
                while (temperatures[i + d] <= ct)
                    d += res[i + d];

                res[i] = d;
            }
        }
        return res;      
    }
}
