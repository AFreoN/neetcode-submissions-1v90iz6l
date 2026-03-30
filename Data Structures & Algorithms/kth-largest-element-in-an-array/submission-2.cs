public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int min = int.MaxValue, max = int.MinValue;
        foreach (var v in nums)
        {
            min = Math.Min(min, v);
            max = Math.Max(max, v);
        }

        int L = max - min + 1;
        Span<int> freq = stackalloc int[L];
        foreach (int v in nums)
            ++freq[v - min];

        for(int i = L - 1; i >= 0; i--)
        {
            k -= freq[i];
            if (k <= 0) return min + i;
        }
        return -1;
    }
}
