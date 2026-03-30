public class Solution {
    public int MaxProduct(int[] nums) {
        int n = nums.Length;
        int result = nums[0], min = result, max = result;
        
        for (int i = 1; i < n; i++)
        {
            int curr = nums[i];
            int maxProduct = max * curr;
            int minProduct = min * curr;
            max = Math.Max(Math.Max(maxProduct, minProduct), curr);
            min = Math.Min(Math.Min(maxProduct, minProduct), curr);
            if (max > result) result = max;
        }
        return result;
    }
}
