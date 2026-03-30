public class Solution {
    public int MaxSubArray(int[] nums) {
        int n = nums.Length;
        int[] dp = new int[n];
        Array.Copy(nums, dp, n);

        for (int i = 1; i < n; i++)
        {
            dp[i] = Math.Max(nums[i], nums[i] + dp[i - 1]);
        }

        int max = dp[0];
        foreach(int v in dp)
            if(v > max)
                max = v;
        return max;
    }
}
