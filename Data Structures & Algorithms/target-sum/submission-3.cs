public class Solution {
    public int FindTargetSumWays(int[] nums, int target) {
        int n = nums.Length, count = 0;

        void dfs(int index, int curSum)
        {
            if (index == n)
            {
                if (curSum == target) count++;
                return;
            }

            dfs(index + 1, curSum + nums[index]);
            dfs(index + 1, curSum - nums[index]);
        }

        dfs(0, 0);
        return count;
    }
}
