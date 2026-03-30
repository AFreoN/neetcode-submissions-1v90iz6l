public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Length, l = 0, sum = 0, size = int.MaxValue;
        for(int r = 0; r < n; r++)
        {
            sum += nums[r];

            while(sum >= target)
            {
                size = Math.Min(size, r - l + 1);
                sum -= nums[l];
                l++;
            }
        }
        return size == int.MaxValue ? 0 : size;
    }
}