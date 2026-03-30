public class Solution {
    public int ClimbStairs(int n) {     
        if(n <= 2) return n;
        Span<int> span = stackalloc int[n];
        span[0] = 1;
        span[1] = 2;
        for(int i = 2; i < n; i++)
        {
            span[i] = span[i - 2] + span[i - 1];
        }
        return span[n - 1];
    }
}
