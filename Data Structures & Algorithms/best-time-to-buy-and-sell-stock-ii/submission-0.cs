public class Solution {
    public int MaxProfit(int[] prices) {
                    int n = prices.Length;
            int curMax = prices[n - 1];
            int result = 0;
            for(int i = n - 2; i >= 0; i--)
            {
                if (prices[i] > curMax)
                {
                    curMax = prices[i];
                    continue;
                }

                result += (curMax - prices[i]);
                curMax = prices[i];
            }
            return result;
    }
}