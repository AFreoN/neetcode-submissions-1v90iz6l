public class Solution {
    public bool Makesquare(int[] matchsticks) {
        int n = matchsticks.Length;

        int total = 0;
        foreach (int v in matchsticks) total += v;
        if(total % 4 != 0) return false;

        Array.Sort(matchsticks, (a, b) => b.CompareTo(a));
        int targetLength = total / 4;
        int[] sides = new int[4];

        bool dfs(int i)
        {
            if (i == n) return true;

            for (int side = 0; side < 4; side++)
            {
                if (side > 0 && sides[side] == sides[side - 1]) continue;
                sides[side] += matchsticks[i];
                if (sides[side] <= targetLength && dfs(i + 1))
                    return true;
                sides[side] -= matchsticks[i];
            }

            return false;
        }

        return dfs(0);
    }
}