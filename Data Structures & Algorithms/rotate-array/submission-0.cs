public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n;
        
        void reverse(int l, int r)
        {
            while(l < r)
                (nums[l], nums[r]) = (nums[r--], nums[l++]);
        }

        reverse(0, n - 1);
        reverse(0, k - 1);
        reverse(k, n - 1);
    }
}