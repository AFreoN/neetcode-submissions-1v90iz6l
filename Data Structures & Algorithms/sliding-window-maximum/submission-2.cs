public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length, oN = n - k + 1;
        int[] output = new int[oN];

        int[] l = new int[n], r = new int[n];
        l[0] = nums[0];
        r[n - 1] = nums[n - 1];
        for(int i = 1; i < n; i++)
        {
            l[i] = i % k == 0 ? nums[i] : Math.Max(l[i-1], nums[i]);

            int j = n - 1 - i;
            r[j] = j % k == 0 ? nums[j] : Math.Max(r[j+1], nums[j]);
        }

        for (int i = 0; i < oN; i++)
            output[i] = Math.Max(l[i + k - 1], r[i]);

        return output;
    }
}
