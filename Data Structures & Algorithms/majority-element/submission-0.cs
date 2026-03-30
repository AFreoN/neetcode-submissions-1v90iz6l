public class Solution {
    public static Random R = new Random();
    public int MajorityElement(int[] nums) {
        int n = nums.Length;
        while(true)
        {
            int candid = nums[R.Next(n)];
            int count = nums.Count(x => x == candid);
            if (count > n / 2)
                return candid;
        }
    }
}