public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length;
        if (n == 1) return nums[0];
        int h1 = 0, h2 = 0, h3 = 0, h4 = 0;
        int tmp1, tmp2;

        for(int i = 0; i < n; i++)
        {
            if(i != 0)
            {
                tmp1 = Math.Max(nums[i] + h1, h2);
                h1 = h2;
                h2 = tmp1;
            }

            if(i != n - 1)
            {
                tmp2 = Math.Max(nums[i] + h3, h4);
                h3 = h4;
                h4 = tmp2;
            }
        }
        return Math.Max(h2, h4);
    }
}
