public class Solution {
    public int Tribonacci(int n) {
        if(n == 0) return 0;
        else if(n == 1) return 1;

        int dp1 = 0, dp2 = 1, dp3 = 1;

        for(int i = 2; i < n; i++){
            int dp = dp1 + dp2 + dp3;
            dp1 = dp2;
            dp2 = dp3;
            dp3 = dp;
        }

        return dp3;
    }
}