public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
            int n = nums.Length, rp = 1;
            int[] r = new int[n];
            r[0] = 1;
            for(int i = 1; i < n; i++)
                r[i] = r[i - 1] * nums[i-1];

            for (int i = n - 1; i >= 0; i--)
            {
                r[i] *= rp;
                rp *= nums[i];
            }

            return r;
    }
}
