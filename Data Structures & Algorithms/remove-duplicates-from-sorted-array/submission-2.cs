public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int res = 0;
        foreach(int v in nums)
            if(nums[res] != v)
                nums[++res] = v;
        return res + 1;
    }
}