public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> res = new List<List<int>>();
        List<int> subset = new List<int>();
        Array.Sort(candidates);
        DFS(candidates, target, 0, 0, subset, res);
        return res;
    }

    void DFS(int[] nums, int target, int depth, int total, List<int> subset, List<List<int>> res)
    {
        if(total == target)
        {
            res.Add(new List<int>(subset));
            return;
        }

        if (total > target || depth >= nums.Length) return;

        subset.Add(nums[depth]);
        DFS(nums, target, depth + 1, total + nums[depth], subset, res);
        subset.RemoveAt(subset.Count - 1);
        while (depth + 1 < nums.Length && nums[depth] == nums[depth + 1])
            depth++;
        DFS(nums, target, depth + 1, total, subset, res);
    }
}
