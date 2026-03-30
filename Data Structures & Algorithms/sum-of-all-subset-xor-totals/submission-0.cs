public class Solution {
    public int SubsetXORSum(int[] nums) {
        int res = 0, n = nums.Length;

        void backtrack(int start, List<int> subset)
        {
            int xorr = 0;
            foreach (int v in subset)
                xorr ^= v;

            res += xorr;

            for (int i = start; i < n; i++)
            {
                subset.Add(nums[i]);
                backtrack(i + 1, subset);
                subset.RemoveAt(subset.Count - 1);
            }
        }

        backtrack(0, new List<int>());
        return res;
    }
}