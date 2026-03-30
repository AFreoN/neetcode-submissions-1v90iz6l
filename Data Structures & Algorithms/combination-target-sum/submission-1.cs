public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = new List<List<int>>();
        List<int> subset = new List<int>();
        DFS(nums, 0, target, 0, subset, res);
        return res;
    }

    void DFS(int[] cans, int depth, int target, int total, List<int> subset, List<List<int>> res)
    {
        if (total == target)
        {
            res.Add(new List<int>(subset));
            return;
        }

        if (depth >= cans.Length || total > target) return;

        subset.Add(cans[depth]);
        DFS(cans, depth, target, total + cans[depth], subset, res);
        subset.RemoveAt(subset.Count - 1);
        DFS(cans, depth + 1, target, total, subset, res);
    }
}
