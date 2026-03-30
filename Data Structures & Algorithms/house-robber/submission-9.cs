public class Solution {
    public int Rob(int[] nums)
    {
        if(1 == nums.Length) return nums[0];
        int r1 = 0, r2 = 0;
        foreach(int v in nums)
        {
            int tmp = Math.Max(v + r1, r2);
            r1 = r2;
            r2 = tmp;
        }
        return r2;
    }
}
