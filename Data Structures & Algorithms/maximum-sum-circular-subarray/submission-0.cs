public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int max = nums[0], min = nums[0];
        int curMax = 0, curMin = 0;
        int total = 0;

        foreach (int v in nums)
        {
            curMax = Math.Max(curMax + v, v);
            max = Math.Max(curMax, max);

            curMin = Math.Min(curMin + v, v);
            min = Math.Min(curMin, min);

            total += v;
        }

        return max > 0 ? Math.Max(max, total - min) : max;
    }
}