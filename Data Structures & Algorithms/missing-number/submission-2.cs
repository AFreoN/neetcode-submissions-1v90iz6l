public class Solution {
    public int MissingNumber(int[] nums) {
        int L = nums.Length, r = L;
        for(int i = 0; i < L; i++)
            r ^= i ^ nums[i];
        return r;
    }
}
