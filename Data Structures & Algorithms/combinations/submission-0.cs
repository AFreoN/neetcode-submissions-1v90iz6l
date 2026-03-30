public class Solution {
    public List<List<int>> Combine(int n, int k) {
            List<List<int>> res = new List<List<int>>();

            void backtrack(int start, List<int> visits)
            {
                if (visits.Count == k)
                {
                    res.Add(new List<int>(visits));
                    return;
                }

                for (int i = start; i <= n - (k - visits.Count) + 1; i++)
                {
                    visits.Add(i);
                    backtrack(i + 1, visits);
                    visits.RemoveAt(visits.Count - 1);
                }
            }

            backtrack(1, new List<int>());
            return res;
    }
}