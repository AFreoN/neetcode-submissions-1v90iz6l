public class Solution {
    public int MaxProfit(int[] prices) {
        int dp1_buy = 0, dp2_buy = 0;
        int dp1_sell = 0;

        for (int i = prices.Length - 1; i >= 0; i--)
        {
            int dp_buy = Math.Max(dp1_sell - prices[i], dp1_buy);
            int dp_sell = Math.Max(dp2_buy + prices[i], dp1_sell);
            dp2_buy = dp1_buy;
            dp1_sell = dp_sell;
            dp1_buy = dp_buy;
        }

        return dp1_buy;
    }
}
