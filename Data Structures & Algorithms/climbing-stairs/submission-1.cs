public class Solution {
    public int ClimbStairs(int n) {     
        if(n <= 2) return n;
        double r5 = Math.Sqrt(5);
        double a = (1 + r5) / 2;
        double b = (1 - r5) / 2;
        return (int)Math.Round((Math.Pow(a, ++n) - Math.Pow(b, n)) / r5);
    }
}
