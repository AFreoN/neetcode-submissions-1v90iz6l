public class Solution {
    public int Rob(int[] nums) {
        int n = nums.Length - 1;
        if(n == 0) return nums[0];
        int h1SecondNeighbor = 0, h1Neighbor = 0, h2SecondNeighbor = 0, h2Neighbor = 0;
        for(int i = 0; i <= n; i++)
        {
            int tmp;
            if(i != n)
            {
                tmp = Math.Max(nums[i] + h1SecondNeighbor, h1Neighbor);
                h1SecondNeighbor = h1Neighbor;
                h1Neighbor = tmp;
            }

            if(i != 0)
            {
                tmp = Math.Max(nums[i] + h2SecondNeighbor, h2Neighbor);
                h2SecondNeighbor = h2Neighbor;
                h2Neighbor = tmp;
            }
        }
        return Math.Max(h1Neighbor, h2Neighbor);
    }
}
