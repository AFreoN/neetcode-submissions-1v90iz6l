public class Solution {
    public double MyPow(double x, int n) {
        if(n == 0) return 1;
            double res = x;
            double factor = res;
            if(n < 0)
            {
                n = Math.Abs(n);
                res = 1 / x;
                factor = res;
            }
            while(--n > 0)
            {
                res *= factor;
            }
            return res;
    }
}
