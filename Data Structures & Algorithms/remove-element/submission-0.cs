public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int n = nums.Length, k = 0;
        int lastId = 0;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != val)
            {
                k++; nums[lastId++] = nums[i];
            }
        }
        return k;
    }
}