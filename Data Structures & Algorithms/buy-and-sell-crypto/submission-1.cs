public class Solution {
    public int MaxProfit(int[] prices) {
       int i = 0, j = i + 1, m = 0;
        while(j < prices.Length)
        {
            int p = prices[j] - prices[i];
            if (p < 0) i = j;
            else if (p > m) m = p;
            j++;
        }
        return m;
    }
}
