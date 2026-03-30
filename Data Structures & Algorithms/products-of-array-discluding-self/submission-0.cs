public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
                    int n = nums.Length;
            int[] pref = Enumerable.Repeat(1, n).ToArray();
            int[] suff = (int[])pref.Clone();

            for(int i = 1; i < n; i++)
            {
                pref[i] = pref[i - 1] * nums[i - 1];
            }

            for (int i = n - 2; i >= 0; i--)
                suff[i] = suff[i + 1] * nums[i + 1];

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
                result[i] = pref[i] * suff[i];

            return result;
    }
}
