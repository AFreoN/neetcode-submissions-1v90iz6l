public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        Dictionary<int,int> dp = new Dictionary<int, int>() { { 0, 1 } };

        foreach(int x in nums)
        {
            Dictionary<int, int> nextDp = new();
            foreach (var kp in dp)
            {
                int key = kp.Key;
                int val = kp.Value;

                if(!nextDp.TryAdd(key + x, val))
                    nextDp[key + x] += val;

                if(!nextDp.TryAdd(key - x, val))
                    nextDp[key - x] += val;
            }
            dp = nextDp;
        }

        return dp.ContainsKey(target) ? dp[target] : 0;
    }
}
