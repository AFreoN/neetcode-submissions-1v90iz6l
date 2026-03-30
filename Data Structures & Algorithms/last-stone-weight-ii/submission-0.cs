public class Solution {
    public int LastStoneWeightII(int[] stones) {
        int stoneSum = stones.Sum();
        int target = stoneSum / 2;
        int[] dp = new int[target + 1];

        foreach(int stone in stones)
        {
            for(int t = target; t >= stone; t--)
                dp[t] = Math.Max(dp[t], dp[t - stone] + stone);
        }

        return stoneSum - 2 * dp[target];
    }
}