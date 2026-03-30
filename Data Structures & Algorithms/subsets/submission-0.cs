public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        List<int> subset = new List<int>();
        DFS(nums, 0, subset, res);
        return res;
    }

    void DFS(int[] nums, int depth, List<int> subset, List<List<int>> res)
    {
        if(depth >= nums.Length)
        {
            res.Add(new List<int>(subset));
            return;
        }

        subset.Add(nums[depth]);
        DFS(nums, depth + 1, subset, res);
        subset.RemoveAt(subset.Count - 1);
        DFS(nums, depth + 1, subset, res);
    }
}
