public class Solution {
    public int MaxProfit(int[] prices) {
            int m = 0;

            for(int i = prices.Length - 1; i >= 1; i--)
            {
                int min = prices[i];
                int j = i - 1;
                while(j >= 0)
                    min = Math.Min(min, prices[j--]);
                
                m = Math.Max(m, prices[i] - min);
            }

            return m;
    }
}
