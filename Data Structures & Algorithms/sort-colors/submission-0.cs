public class Solution {
    public void SortColors(int[] nums) {
        int n = nums.Length;
        Span<int> span = stackalloc int[3];
        foreach (int v in nums)
            span[v]++;

        int index = 0;
        for(int i = 0; i < 3; i++)
        {
            while (span[i]-- > 0)
                nums[index++] = i;
        }
    }
}