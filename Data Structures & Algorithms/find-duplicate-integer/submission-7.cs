public class Solution {
    public int FindDuplicate(int[] nums) {
        foreach (int v in nums)
        {
            int c = Math.Abs(v);
            if (nums[c] < 0) return c;
            nums[c] *= -1;
        }
        return -1;
    }
}
