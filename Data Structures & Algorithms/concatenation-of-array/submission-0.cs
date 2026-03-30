public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length, fn = n * 2;
        int[] result = new int[fn];
        for(int i = 0; i < fn; i++)
            result[i] = nums[i % n];
        return result;
    }
}