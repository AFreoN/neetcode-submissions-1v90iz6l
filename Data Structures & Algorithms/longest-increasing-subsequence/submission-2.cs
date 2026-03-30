public class Solution {
    public int LengthOfLIS(int[] nums) {
        int n = nums.Length;
        int res = 1;
        Span<int> dp = stackalloc int[n];
        dp.Fill(1);
        for(int i = 1; i < n; i++)
        {
            for(int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i])
                    dp[i] = Math.Max(dp[i], dp[j] + 1); 
            }
            if (dp[i] > res) res = dp[i];
        }

        return res;
    }
}
