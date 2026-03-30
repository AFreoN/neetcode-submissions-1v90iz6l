public class Solution {
    public bool CanPartition(int[] nums) {
        int target = nums.Sum();
        if(target % 2 != 0) return false;
        target /= 2;
        Span<bool> dp = stackalloc bool[target + 1];
        dp[0] = true;
        foreach(int num in nums)
        {
            for(int i = target; i >= 0; i--)
            {
                if(dp[i] && i + num <= target)
                    dp[i + num] = true; 
            }
        }
        return dp[target];
    }
}
