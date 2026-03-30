public class Solution {
    public bool CanJump(int[] nums) {
        int jump = nums.Length - 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] + i >= jump) jump = i;
        }
        return jump == 0;
    }
}
