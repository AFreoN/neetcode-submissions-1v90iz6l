public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        int n = cost.Length;
        Span<int> mem = stackalloc int[n];
        mem.Fill(-1);

        int DFS(int i, Span<int> mem)
        {
            if (i >= n) return 0;
            if (mem[i] != -1) return mem[i];
            mem[i] = cost[i] + Math.Min(DFS(i + 1, mem), DFS(i + 2, mem));
            return mem[i];
        }
        return Math.Min(DFS(0, mem), DFS(1, mem));
    }
}
