public class Solution {
    public List<List<int>> PermuteUnique(int[] nums) {
            int n = nums.Length;
            Array.Sort(nums);
            List<List<int>> res = new List<List<int>>();

            void backtrack(List<int> perm, bool[] visited)
            {
                if (perm.Count == n)
                {
                    res.Add(new List<int>(perm));
                    return;
                }

                for (int i = 0; i < n; i++)
                {
                    if (visited[i]) continue;
                    if(i > 0 && nums[i] == nums[i-1] && !visited[i-1]) continue;

                    visited[i] = true;
                    perm.Add(nums[i]);
                    backtrack(perm, visited);
                    perm.RemoveAt(perm.Count - 1);
                    visited[i] = false;
                }
            }

            backtrack(new List<int>(), new bool[nums.Length]);
            return res;
    }
}