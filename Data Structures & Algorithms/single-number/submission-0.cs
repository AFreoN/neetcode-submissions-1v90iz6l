public class Solution {
    public int SingleNumber(int[] nums) {
        int r = 0;
        foreach(int v in nums) r ^= v;
        return r;
    }
}
