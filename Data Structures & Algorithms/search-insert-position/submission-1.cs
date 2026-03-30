public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0, r = nums.Length - 1;
        while (l <= r)
        {
            int m = (r + l) / 2;
            if (nums[m] == target) return m;
            if(target > nums[m]) l = m + 1;
            else r = m - 1;
        }
        return l;
    }
}