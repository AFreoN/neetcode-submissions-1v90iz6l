public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        int prev = cost[0];
        int prev2 = Math.Min(cost[0] + cost[1], cost[1]);
        for (int i = 2; i < n; i++)
        {
            int tmp = prev2;
            prev2 = cost[i] + Math.Min(prev, prev2);
            prev = tmp;
        }
        return Math.Min(prev, prev2);
    }
}
