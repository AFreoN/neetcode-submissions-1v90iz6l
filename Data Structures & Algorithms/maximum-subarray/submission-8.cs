public class Solution {
    public int MaxSubArray(int[] nums) {
        int globalSum = int.MinValue, sum = 0;

        foreach(int v in nums)
        {
            sum += v;
            globalSum = Math.Max(globalSum, sum);
            if (sum < 0) sum = 0;
        }
        return globalSum;
    }
}
