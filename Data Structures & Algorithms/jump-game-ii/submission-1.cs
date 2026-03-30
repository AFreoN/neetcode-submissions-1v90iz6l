public class Solution {
    public int Jump(int[] nums) {
        int n = nums.Length, farthest = 0, jumps = 0, currEnd = 0;

        for (int i = 0; i < n - 1; i++)
        {
            farthest = Math.Max(farthest, nums[i] + i);

            if (farthest == n - 1) return ++jumps;
            else if(i == currEnd)
            {
                jumps++;
                currEnd = farthest;
            }
        }

        return jumps;
    }
}
