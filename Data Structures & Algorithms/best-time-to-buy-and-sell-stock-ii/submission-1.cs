public class Solution {
    public int MaxProfit(int[] prices) {
        int n = prices.Length, result = 0;
        for (int i = 1; i < n; i++)
            if (prices[i - 1] < prices[i])
                result += (prices[i] - prices[i - 1]);
        return result;
    }
}