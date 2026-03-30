public class Solution {
    public int UniquePaths(int m, int n) {
        long res = 1;
        if(m > n)
            (m, n) = (n, m);

        for(int i = 1; i < m; i++)
            res = res * (n - 1 + i) / i;
        
        return (int)res;
    }
}
