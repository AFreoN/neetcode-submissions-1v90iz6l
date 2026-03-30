public class Solution {
    public int HammingWeight(uint n) {
        int r = 0;
        while(n != 0)
        {
            n &= (n-1);
            r++;
        }
        return r;
    }
}
