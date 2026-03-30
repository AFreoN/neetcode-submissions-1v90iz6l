public class Solution {
    public bool Makesquare(int[] matchsticks) {
        int n = matchsticks.Length;

        int total = 0;
        foreach (int v in matchsticks) total += v;
        if(total % 4 != 0) return false;

        Array.Sort(matchsticks, (a, b) => b.CompareTo(a));
        int target = total / 4;

        bool dfs(int start, int sum, int edge, bool[] used)
        {
            // If three edges found, then mathematically remaining ones form the fourth
            if (edge == 3) return true;

            if (sum == target)  // if target reached, then we move to finding the next edge
                return dfs(0, 0, edge + 1, used);

            for (int i = start; i < n; i++) // even index from start should be checked for finding edge
            {
                if (used[i] || sum + matchsticks[i] > target) continue; // if already used or sum becomes greater than target, go to next

                if (i > 0 && matchsticks[i] == matchsticks[i - 1] && !used[i - 1]) continue; // if we visited previous value and it's same as this and was not usable, then this is also not usable

                used[i] = true;
                if(dfs(i + 1, sum + matchsticks[i], edge, used))
                    return true;
                used[i] = false;

                if (sum == 0 || sum + matchsticks[i] == target) break;
            }

            return false;
        }

        return dfs(0, 0, 0, new bool[n]);
    }
}