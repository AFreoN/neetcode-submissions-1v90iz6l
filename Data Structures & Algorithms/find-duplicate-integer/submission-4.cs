public class Solution {
    public int FindDuplicate(int[] nums) {
        int n = nums.Length - 1;
        for (int i = 0; i < nums.Length; i++)
        {
            int c = Math.Abs(nums[i]);
            nums[c - 1] *= -1;
            if (nums[c - 1] > 0)
                    return c;
        }
        return 0;
    }
}
