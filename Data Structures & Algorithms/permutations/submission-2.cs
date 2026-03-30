public class Solution {
    public List<List<int>> Permute(int[] nums) {
        int L = nums.Length;
        List<List<int>> res = new List<List<int>>();
        DFS(nums, new List<int>(), stackalloc bool[L], res);
        return res;
    }

    void DFS(int[] nums, List<int> perm, Span<bool> pick, List<List<int>> res)
    {
        if(perm.Count == nums.Length)
        {
            res.Add(new List<int>(perm));
            return;
        }

        for(int i = 0; i < nums.Length; i++)
        {
            if (!pick[i])
            {
                perm.Add(nums[i]);
                pick[i] = true;
                DFS(nums, perm, pick, res);
                perm.RemoveAt(perm.Count - 1);
                pick[i] = false;
            }
        }
    }
}
