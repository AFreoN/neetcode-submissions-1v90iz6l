public class Solution {
    public bool Makesquare(int[] matchsticks) {
        int n = matchsticks.Length;
        if(n < 4) return false;

        int total = matchsticks.Sum();
        if(total % 4 != 0) return false;

        int targetLength = total / 4;
        int[] sides = new int[4];

        bool dfs(int i)
        {
            if (i == n) return sides[0] == sides[1] && sides[1] == sides[2] && sides[2] == sides[3];

            for (int side = 0; side < 4; side++)
            {
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