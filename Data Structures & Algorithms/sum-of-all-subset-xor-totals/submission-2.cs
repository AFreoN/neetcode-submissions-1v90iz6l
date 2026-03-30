public class Solution {
    public int SubsetXORSum(int[] nums) {
        int res = 0;

        foreach (int v in nums)
            res |= v;

        return res << (nums.Length - 1);
    }
}