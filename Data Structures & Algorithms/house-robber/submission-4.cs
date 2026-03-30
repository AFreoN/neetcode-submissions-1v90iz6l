public class Solution {
    public int Rob(int[] nums)
    {
        int n = nums.Length;
        int[] memo = new int[n];
        Array.Fill(memo, -1);
        int dfs(int i)
        {
            if (i >= n) return 0;
            if (memo[i] != -1) return memo[i];
            memo[i] = Math.Max(dfs(i + 1), nums[i] + dfs(i + 2));
            return memo[i];
        }
        return dfs(0);
    }
}
