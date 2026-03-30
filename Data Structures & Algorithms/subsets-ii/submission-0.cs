public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        Array.Sort(nums);
        DFS(nums, 0, new List<int>(), res);
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
        while(depth + 1 < nums.Length && nums[depth] == nums[depth + 1])
            depth++;
        DFS(nums, depth + 1, subset, res);
    }
}
